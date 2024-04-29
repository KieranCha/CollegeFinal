using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using Task2Prototype.Objects;

namespace Task2Prototype
{
    public enum Entity
    {
        User,
        Article,
        Booking,
        PaymentInfo
    }

    public enum ArticleFilter // to be used in GetArticles
    {
        None,
        EducatorExclusiveOnly,
        ExcludeEducatorExclusive
    }


    static class DatabaseManager
    {
        static string DBlocation = "C:\\Users\\EXAM1241\\OneDrive - Middlesbrough College\\Documents\\Kieran Chalmers\\Task 2\\Task2Prototype\\Task2Prototype\\Task2PrototypeDatabase.mdf"; // this should be |DataDirectory| but that was causing errors so its hard coded
        static string ConnectionString =                                                                                                                                                    // you'll have to change this to use on your local machine
            $"Server=(LocalDB)\\MSSQLLocalDB;" +
            $"Integrated Security=true;AttachDbFilename={DBlocation};";

        static Dictionary<Type, string> typeProcedurePairing = new Dictionary<Type, string>() // Accessing this with a type in Get<>
        {                                                                                     // will return its relevant find procedure
            { typeof(User), "Find-User"},
            { typeof(Booking), "Find-UserBookings" },
            { typeof(PaymentInformation), "Find-UserPaymentInfo" },
            { typeof(Article), "Find-Article" }
        };

        // Pass filter enum and get function back to use in PaginationFunction :), this instead of large switch case in GetArticles
        static Dictionary<ArticleFilter, Func<ArticleSearchResult, bool>> filterFunctionPairing = new Dictionary<ArticleFilter, Func<ArticleSearchResult, bool>>()
        {
            { ArticleFilter.None, null},
            { ArticleFilter.ExcludeEducatorExclusive, (ArticleSearchResult x) => !x.EducatorExclusive},
            { ArticleFilter.EducatorExclusiveOnly, (ArticleSearchResult x) => x.EducatorExclusive}
        };


        // Take in a child of create and turn it into a dictionary, the create objects have the same properties as 
        // parameters of their respective create stored procedures, so its easy to pass those as the parameters for the
        // stored procedure!!!
        /// <summary>
        /// Uses a create object to create an object on the database
        /// </summary>
        /// <typeparam name="T">Create object type being passed</typeparam>
        /// <param name="Create">Create object</param>
        public static void Create<T>(Create<T> Create)
        {
            // Convert Create object into dictionary with Linq, dictionary is <ParamName, ParamValue>, I use object because value != string every time
            Dictionary<string, object> CreateDictionary =
                Create.type.GetProperties(BindingFlags.Public | BindingFlags.Instance)
                .ToDictionary(prop => '@' + prop.Name, prop => prop.GetValue(Create.EntityInfo, null)); //Use '@' infront because of SQL procedure parameter formatting

            SqlConnection conn = new SqlConnection(ConnectionString);
            SqlCommand sqlCommand = new SqlCommand($"Create-{Create.entity}", conn) // Use the entity to find the correct stored procedure for creating
            {                                                                       // Create stored procedures follow strict naming convention to make this possible
                CommandType = CommandType.StoredProcedure
            };
            foreach (string Property in CreateDictionary.Keys) // construct parameters
            {
                if (Property == "@entity" || Property == "@type" || Property == "@EntityInfo") continue; // Dont want to pass these as they're not parameters
                if (CreateDictionary[Property].GetType() == typeof(bool)) // Logic to hand and pass booleans as a bit
                {                                                         // because the SQL schema has booleans stored as bits not plain text
                    sqlCommand.Parameters.AddWithValue(Property, (bool)CreateDictionary[Property] ? 1 : 0);
                    continue;
                }
                sqlCommand.Parameters.AddWithValue(Property, CreateDictionary[Property]); // Add Parameters by interating through the keys, which are the parameter names, which are associated with the values :)
            }
            conn.Open(); // execute command
            sqlCommand.ExecuteNonQuery();
            conn.Close();
        }

        /// <summary>
        /// Gets the first result with provided ID, best used to get information on a user, users payment information or article
        /// </summary>
        /// <typeparam name="T">Type of object you're looking for</typeparam>
        /// <param name="id">ID of desired object</param>
        /// <returns>Object of type T with ID provided, if none is found empty object will be returned </returns>
        public static T Get<T>(int id)
        {
            SqlConnection conn = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand(typeProcedurePairing[typeof(T)], conn) { CommandType = CommandType.StoredProcedure };
            cmd.Parameters.AddWithValue("@Id", id); // Switch parameter name
            conn.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            var parser = reader.GetRowParser<T>(typeof(T)); // Use dapper parser to map results to provided object
            T result = reader.Read() ? parser(reader) : default;
            conn.Close();
            return result;
        }

        /// <summary>
        /// Get a list of articles with a search query
        /// Results are paginated to optimise memory usage
        /// </summary>
        /// <param name="SearchQuery">Search query, provide '*' to get every result</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Maximum number of results to return, prevent loading too many to memory </param>
        /// <returns>List of results, will be empty if none found</returns>
        public static List<ArticleSearchResult> GetArticles(string SearchQuery = "*", ArticleFilter filter = ArticleFilter.None, int pageNumber = 1, int pageSize = 10)
        {
            List<ArticleSearchResult> list = new List<ArticleSearchResult>();
            SqlConnection conn = new SqlConnection(ConnectionString);

            SqlCommand cmd = new SqlCommand("Search-Article", conn) { CommandType = CommandType.StoredProcedure };
            cmd.Parameters.AddWithValue("@SearchQuery", SearchQuery);
            conn.Open();
            cmd.ExecuteNonQuery();
            SqlDataReader reader = cmd.ExecuteReader();
            if (filter == ArticleFilter.None) list = PaginateReader<ArticleSearchResult>(reader, pageNumber, pageSize);
            else list = PaginateReader(reader, filterFunctionPairing[filter], pageNumber, pageSize);
            conn.Close();
            return list;

        }

        /// <summary>
        /// Get every booking of current user
        /// Results are paginated to optimise memory usage
        /// </summary>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Maximum number of results to return, prevent loading too many to memory </param>
        /// <returns>List of results, will be empty if none found</returns>
        public static List<Booking> GetBookings(int pageNumber = 1, int pageSize = 10)
        {
            
            SqlConnection conn = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand("Find-UserBookings", conn) { CommandType = CommandType.StoredProcedure };
            cmd.Parameters.AddWithValue("@Id", Globals.CurrentUser.id);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            List<Booking> list = PaginateReader<Booking>(reader, pageNumber, pageSize);
            conn.Close();
            return list;
        }

        /// <summary>
        /// Return the ID of a user with a matching username and password
        /// </summary>
        /// <param name="Username">Username of the User</param>
        /// <param name="Password">Password of the User</param>
        /// <returns>ID of the user with username and password, 0 if no user exsists</returns>
        public static int AuthoriseUser(string Username, string Password)
        {
            SqlConnection conn = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand("Auth-User", conn) { CommandType = CommandType.StoredProcedure };
            cmd.Parameters.AddWithValue("username", Username);
            cmd.Parameters.AddWithValue("password", Password);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read()) return reader.GetInt32(0);
            return 0;

        }

        /// <summary>
        /// Paginate data from SqlDataReader object
        /// </summary>
        /// <typeparam name="T">Type of data in SqlDataReader</typeparam>
        /// <param name="reader">SqlDataReader object to paginate</param>
        /// <param name="pageNumber">Current page</param>
        /// <param name="pageSize">The number of results per page</param>
        /// <returns>List of Type T with count =< pageSize</returns>
        static List<T> PaginateReader<T>(SqlDataReader reader, int pageNumber = 1, int pageSize = 10)
        {
            List<T> paginatedData = new List<T>();
            var parser = reader.GetRowParser<T>(typeof(T));
            // we start x at one because we need to increment the reader till it reaches our page start still
            for (int x = 0; x < (pageNumber * pageSize); x++) // iterate through the list of results, parse and filter them and add them to the list
            {
                if (reader.Read())
                {
                    if (x < (pageSize * (pageNumber - 1))) continue; // dont add results from prior pages
                    else paginatedData.Add(parser(reader));
                }
                else break; // exit out of this early if theres no more results
            }
            return paginatedData;
        }

        /// <summary>
        /// Paginate data from SqlDataReader object, with filtering passed as function
        /// </summary>
        /// <typeparam name="T">Type of data in SqlDataReader</typeparam>
        /// <param name="reader">SqlDataReader object to paginate</param>
        /// <param name="filter">filter to act on list, can be used to filter further after the stored procedure</param>
        /// <param name="pageNumber">Current page</param>
        /// <param name="pageSize">The number of results per page</param>
        /// <returns>List of Type T with count =< pageSize</returns>
        static List<T> PaginateReader<T>(SqlDataReader reader, Func<T, bool> filter, int pageNumber = 1, int pageSize = 10)
        {
            List<T> Data = new List<T>();
            var parser = reader.GetRowParser<T>(typeof(T));
            while (reader.Read())
            {
                T data = parser(reader); // parse once for performance
                if (filter.Invoke(data)) Data.Add(data);
            }

            if (pageSize >= Data.Count && pageNumber == 1) return Data;
            // get slice of list representive of page
            try { return Data.GetRange(Math.Max((pageSize * (pageNumber - 1)), 0), 
                (pageSize * pageNumber) > Data.Count ? Data.Count - (pageSize * (pageNumber - 1)) : pageSize); } // math explained in dev log
            catch
            {
                return new List<T> { };
            }
        }

        /// <summary>
        /// Get the total number of articles in the database
        /// </summary>
        /// <returns>Total number of articles in the database</returns>
        public static int GetTotalArticles()
        {
            SqlConnection conn = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand("Count-Articles", conn) { CommandType = CommandType.StoredProcedure };
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            int result = reader.GetInt32(0);
            conn.Close();
            return result;
        }

        /// <summary>
        /// Get total number of bookings belonging to the current User
        /// </summary>
        /// <returns>
        /// Total number of bookings of current user,
        /// though returns -1 if theirs no current user
        /// </returns>
        public static int GetTotalBookings()
        {
            if (Globals.CurrentUser == null) return -1;
            SqlConnection conn = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand("Count-Bookings", conn) { CommandType = CommandType.StoredProcedure };
            cmd.Parameters.AddWithValue("@userID", Globals.CurrentUser.id);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            int result = reader.GetInt32(0);
            conn.Close();
            return result;
        }

    }
}
