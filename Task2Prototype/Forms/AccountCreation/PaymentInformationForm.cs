using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task2Prototype.Managers;

namespace Task2Prototype.Forms.AccountCreation
{
    public partial class PaymentInformationForm : Form
    {
        const string CardHolderNameText = "Card Holders Full Name";
        const string CVVtext = "CVV";
        const string CardNumberText = "Card Number";
        const string ExpiryDateText = "Expiry Date";

        // placeholder text stuff
        void HolderNameFocus(object sender, EventArgs e) => CardHolderNameInput.Text = (CardHolderNameInput.Text == CardHolderNameText) ? string.Empty : CardHolderNameInput.Text;
        void HolderNameUnfocus(object sender, EventArgs e) => CardHolderNameInput.Text = (CardHolderNameInput.Text == string.Empty) ? CardHolderNameText : CardHolderNameInput.Text;
        void CVVtextFocus(object sender, EventArgs e) => CVVinput.Text = (CVVinput.Text == CVVtext) ? string.Empty : CVVinput.Text;
        void CVVtextUnfocus(object sender, EventArgs e) => CVVinput.Text = (CVVinput.Text == string.Empty) ? CVVtext : CVVinput.Text;
        void CardNumberFocus(object sender, EventArgs e) => CardNumberInput.Text = (CardNumberInput.Text == CardNumberText) ? string.Empty : CardNumberInput.Text;
        void CardNumberUnfocus(object sender, EventArgs e) => CardNumberInput.Text = (CardNumberInput.Text == string.Empty) ? CardNumberText : CardNumberInput.Text;
        void ExpiryDateFocus(object sender, EventArgs e) => ExpiryDateInput.Text = (ExpiryDateInput.Text == ExpiryDateText) ? string.Empty : ExpiryDateInput.Text;
        void ExpiryDateUnfocus(object sender, EventArgs e) => ExpiryDateInput.Text = (ExpiryDateInput.Text == string.Empty) ? ExpiryDateText : ExpiryDateInput.Text;

        private void TextChanged(object sender, EventArgs e)
        {
            // iterate through every control and gather textboxes in one list, 
            // use .all() to check if all of them are "valid"
            List<TextBox> textBoxes = new List<TextBox>(); 
            this.Controls.Cast<Control>().ToList().ForEach(x =>
            {
                if (x.GetType() == typeof(TextBox)) textBoxes.Add((TextBox)x);
            });
            ConfirmPaymentLblBtn.Enabled = textBoxes.All(x => ValidateInput(x.Text));
        }
        // no time to add proper card validation :(
        bool ValidateInput(string x) => (!string.IsNullOrWhiteSpace(x)) &&
            (x != CardHolderNameText) &&
            (x != CVVtext) &&
            (x != ExpiryDateText) &&
            (x != CardNumberText);

        public PaymentInformationForm()
        {
            InitializeComponent();
        }

        private void ConfirmPaymentLblBtn_Click(object sender, EventArgs e)
        {
            Globals.CurrentUser.CreatePaymentInformation(CVVinput.Text, CardNumberInput.Text, CardHolderNameInput.Text, ExpiryDateInput.Text);
            Close();
        }
    }
}
