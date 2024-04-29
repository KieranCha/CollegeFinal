#nullable enable // get rid of intellicode green underline >:(
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task2Prototype.Objects;

namespace Task2Prototype.Managers
{
    static class UserManager 
    {
        // account state actions
        /// <summary>
        /// Create a new user
        /// </summary>
        /// <param name="newUser">Create user object</param>
        /// <returns>Bool representive of the success of user creation, True = account created, false = account creation failed</returns>
        public static bool SignUpUser(string username, string password, bool educator = false) // bool represents success of creating new account
        {
            if (Globals.CurrentUser != null) return false;
            try { Create<CreateUser>.NewUser(username, password, educator); }
            catch (SqlException) 
            {
                MessageBox.Show("Username taken"); // 99% chance this is the reason an exception was thrown
                return false; 
            } // only line I except to throw SqlError, mainly looking for Unique constraint violation on name
            return LoginUser(username, password); // will handle setting current user
        }
        public static bool LoginUser(string username, string password)
        {
            if (Globals.CurrentUser != null) return false; // this function will be used seperate of signup so this check still needs to be here
            int userId = DatabaseManager.AuthoriseUser(username, password);
            if (userId == 0) return false;
            Globals.CurrentUser = new CurrentUser(DatabaseManager.Get<User>(userId));
            Globals.MainForm.UpdateControls();
            return true;
        }
        public static void LogOutUser()
        {
            Globals.CurrentUser = null;
            Globals.MainForm.UpdateControls();
        }
        static public void refreshUser()
        {
            if (Globals.CurrentUser == null) return;
            // GET NEW data for user
            Globals.CurrentUser = new CurrentUser(DatabaseManager.Get<User>(Globals.CurrentUser.id));
        }
    }

    class CurrentUser : User
    {
        public CurrentUser(User user)
        {
            this.Name = user.Name;
            this.id = user.id;
            this.LoyaltyPoints = user.LoyaltyPoints;
            this.PaymentLinked = user.PaymentLinked;
            this.Educator = user.Educator;
            this.HasBookings = user.HasBookings;
        }


        // user actions
        public bool CreateBooking(string _DateStart, string _DateEnd, string _HotelSelection, int _Price, int _StandardTickets, int _ChildTickets)
        {
            try { Create<CreateBooking>.NewBooking(this.id, _DateStart, _DateEnd, _HotelSelection, _Price, _StandardTickets, _ChildTickets); }
            catch (SqlException) { return false; }
            UserManager.refreshUser();
            return true;
        }
        public bool CreatePaymentInformation(string _Csv, string _CardNumber, string _CardHolderName, string _CardExpiryDate)
        {
            try { Create<CreatePaymentInformation>.NewPaymentInformation(_Csv, _CardNumber, _CardHolderName, _CardExpiryDate, this.id); }
            catch (SqlException) { return false; }
            UserManager.refreshUser();
            return true;
        }

        public List<Booking> GetBookings(int pageNumber = 1, int pageSize = 10) => DatabaseManager.GetBookings(pageNumber, pageSize);
        public PaymentInformation GetPaymentInformation() => DatabaseManager.Get<PaymentInformation>(this.id);

    }
}
