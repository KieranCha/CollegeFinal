using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task2Prototype.Custom_Controls;
using Task2Prototype.Managers;
using Task2Prototype.Objects;

namespace Task2Prototype.Forms
{
    public partial class BookingViewer : Form
    {
        List<Booking> bookings;
        public BookingViewer()
        {
            InitializeComponent();
        }
        void RefreshBookings()
        {
            bookings = Globals.CurrentUser.GetBookings(1, 5);
            int currentIndex = 0;
            // article fill from mainform, to see how it works see refreshArticles function in mainform
            this.Controls.Cast<Control>().ToList().ForEach(x =>
            {
                if (x.GetType() == typeof(BookingControl))
                {
                    try
                    {
                        x.Visible = true;
                        ((BookingControl)x).SetBooking(bookings[currentIndex]);
                    }
                    catch (ArgumentOutOfRangeException) { x.Visible = false; }
                    currentIndex++;
                }
            });
        }
        private void BookingViewer_Load(object sender, EventArgs e)
        {
            RefreshBookings();
        }

        private void AddBookingBtn_Click(object sender, EventArgs e)
        {
            BookingManager bookingForm = new BookingManager();
            bookingForm.ShowDialog();
            RefreshBookings();
        }
    }
}
