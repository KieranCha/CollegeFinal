using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2Prototype.Objects
{
    public class Booking
    {
        public string DateStart, DateEnd;
        public string HotelSelection;
        public int Price;
        public int StandardTickets, ChildTickets;
    }

    class CreateBooking : Create<CreateBooking>
    {
        public int UserId { get; set; }
        public string DateStart { get; set; }
        public string DateEnd { get; set; }
        public string HotelSelection { get; set; }
        public int Price { get; set; }
        public int StandardTickets { get; set; }
        public int ChildTickets { get; set; }

        public CreateBooking(int _UserId, string _DateStart, string _DateEnd, string _HotelSelection, int _Price, int _StandardTickets, int _ChildTickets)
        {
            entity = Entity.Booking;
            type = this.GetType();
            UserId = _UserId;
            DateStart = _DateStart;
            DateEnd = _DateEnd;
            HotelSelection = _HotelSelection;
            Price = _Price;
            StandardTickets = _StandardTickets;
            ChildTickets = _ChildTickets;
            EntityInfo = this;
        }

    }
}
