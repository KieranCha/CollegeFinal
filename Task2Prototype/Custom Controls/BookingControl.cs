using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task2Prototype.Objects;

namespace Task2Prototype.Custom_Controls
{
    public partial class BookingControl : UserControl
    {
        Booking Booking;
        public BookingControl()
        {
            InitializeComponent();
        }
        public void SetBooking(Booking booking)
        { 
            Booking = booking;
            DateLabel.Text = $"{Booking.DateStart} => {Booking.DateEnd}";
            TicketDisplay.Text = "Ticket Amount: " +(Booking.StandardTickets + Booking.ChildTickets).ToString();
        }
        private void BookingControl_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
