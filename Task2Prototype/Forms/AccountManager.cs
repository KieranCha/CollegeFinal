using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task2Prototype.Forms.AccountCreation;

namespace Task2Prototype.Forms
{
    public partial class AccountManager : Form
    {
        public AccountManager()
        {
            InitializeComponent();
        }

        private void AccountManager_Load(object sender, EventArgs e)
        {
            NameLbl.Text = Globals.CurrentUser.Name;
            PaymentInfoBtn.Enabled = !Globals.CurrentUser.PaymentLinked;
        }

        private void PaymentInfoBtn_Click(object sender, EventArgs e)
        {
            PaymentInformationForm form = new PaymentInformationForm();
            form.ShowDialog();
            Close();
        }
    }
}
