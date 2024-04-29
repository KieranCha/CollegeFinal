using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task2Prototype.Forms
{
    public partial class BookingManager : Form
    {
        int _ChildTicketAmount = 0;
        int ChildTicketAmount
        {
            get { return _ChildTicketAmount; }
            set
            {
                _ChildTicketAmount = (value < 0) ? 0 : value;
                ChildTicketDisplay.Text = _ChildTicketAmount.ToString();
            }
        }
        int _StandardTicketAmount = 0;
        int StandardTicketAmount
        {
            get { return _StandardTicketAmount; }
            set
            {
                _StandardTicketAmount = (value < 0) ? 0 : value;
                StandardTicketDisplay.Text = _StandardTicketAmount.ToString();
            }
        }
        public BookingManager()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BookingManager_Load(object sender, EventArgs e)
        {

        }

        private void ChildTicketIncrement_Click(object sender, EventArgs e) => ChildTicketAmount++;
        private void ChildTicketDecrement_Click(object sender, EventArgs e) => ChildTicketAmount--;
        private void StandardTicketIncrement_Click(object sender, EventArgs e) => StandardTicketAmount++;
        private void StandardTicketDecrement_Click(object sender, EventArgs e) => StandardTicketAmount--;

        // make sure both cant be selected
        private void PremiumHotelCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (PremiumHotelCheck.Checked)
            {
                StandardHotelCheck.Checked = false;
            }
        }

        private void StandardHotelCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (StandardHotelCheck.Checked)
            {
                PremiumHotelCheck.Checked = false;
            }
        }

        private void CreateBookingBtn_Click(object sender, EventArgs e)
        {
            // no time for proper dates
            if (String.IsNullOrWhiteSpace(StartDateInput.Text)) return;
            string HotelSelection = string.Empty;
            // this is okay because they cant be checked at the same time no so no override
            if (PremiumHotelCheck.Checked) HotelSelection = "PremiumHotel";
            if (StandardHotelCheck.Checked) HotelSelection = "StandardHotel";
            
            Globals.CurrentUser.CreateBooking(
                StartDateInput.Text,
                (String.IsNullOrWhiteSpace(EndDateInput.Text) ? StartDateInput.Text : EndDateInput.Text),
                HotelSelection,
                CalculatePrice(),
                StandardTicketAmount,
                ChildTicketAmount
                );
            this.Close();

        }

        // not accurate because lack of validation
        private int CalculatePrice()
        {
            int price = 0;
            int totalTickets = ChildTicketAmount + StandardTicketAmount;
            if (PremiumHotelCheck.Checked) price += totalTickets * 49;
            if (StandardHotelCheck.Checked) price += totalTickets * 29;
            price += ChildTicketAmount * 25;
            price += StandardTicketAmount * 50;
            return price;

        }
    }
}
