using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task2Prototype.Objects
{
    internal class Create<T> // Create classes inherit from this to pass into Create Function on database Manager
    {
        public Entity entity;
        public Type type;
        public T EntityInfo;

        // create methods
        public static void NewUser(string name, string password, bool educator = false) => 
            DatabaseManager.Create(new CreateUser(name, password, educator));
        public static void NewBooking(int _UserId, string _DateStart, string _DateEnd, string _HotelSelection, int _Price, int _StandardTickets, int _ChildTickets) =>
            DatabaseManager.Create(new CreateBooking(_UserId, _DateStart, _DateEnd, _HotelSelection, _Price, _StandardTickets, _ChildTickets));
        public static void NewPaymentInformation(string _Csv, string _CardNumber, string _CardHolderName, string _CardExpiryDate, int _UserId) =>
            DatabaseManager.Create(new CreatePaymentInformation(_Csv, _CardNumber, _CardHolderName, _CardExpiryDate, _UserId));
    }
}
