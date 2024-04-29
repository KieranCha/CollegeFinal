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
    public partial class Signup : Form
    {
        const string PasswordText = "Password";
        const string UsernameText = "Username";
        const string ConfirmPasswordText = "Confirm Password";
        public Signup()
        {
            InitializeComponent();
        }


        // Confirm password placeholder text logic
        private void ConfirmPasswordInput_Enter(object sender, EventArgs e)
        {
            if (ConfirmPasswordInput.Text == ConfirmPasswordText && ConfirmPasswordInput.PasswordChar == '\0')
            {
                ConfirmPasswordInput.Text = string.Empty;
                ConfirmPasswordInput.PasswordChar = '*';
            }
        }
        private void ConfirmPasswordInput_Leave(object sender, EventArgs e)
        {
            if (ConfirmPasswordInput.Text == string.Empty)
            {
                ConfirmPasswordInput.Text = PasswordText;
                ConfirmPasswordInput.PasswordChar = '\0';
            }
        }

        // password placeholder text logic 
        private void PasswordInput_Enter(object sender, EventArgs e)
        {
            if (PasswordInput.Text == PasswordText && PasswordInput.PasswordChar == '\0')
            {
                PasswordInput.Text = string.Empty;
                PasswordInput.PasswordChar = '*';
            }
        }
        private void PasswordInput_Leave(object sender, EventArgs e)
        {
            if (PasswordInput.Text == string.Empty)
            {
                PasswordInput.Text = PasswordText;
                PasswordInput.PasswordChar = '\0';
            }
        }

        // username placeholder text logic 
        private void UsernameInput_Enter(object sender, EventArgs e) => UsernameInput.Text = (UsernameInput.Text == UsernameText) ? string.Empty : UsernameInput.Text;
        private void UsernameInput_Leave(object sender, EventArgs e) => UsernameInput.Text = (UsernameInput.Text == string.Empty) ? UsernameText : UsernameInput.Text;


        // signup logic
        private void EnterKeyPressed(object sender, KeyPressEventArgs key)
        {
            // QOL from login, if you press enter on one of the inputs it'll either
            // focus to one of the empty/incomplete ones or just attempt log in if their complete
            if (key.KeyChar != (char)Keys.Enter) return;
            if (UsernameInput.Text == string.Empty || UsernameInput.Text == UsernameText)
            {
                UsernameInput.Focus();
                return;
            }
            if (PasswordInput.Text == string.Empty || PasswordInput.Text == PasswordText)
            {
                PasswordInput.Focus();
                return;
            }
            if (ConfirmPasswordInput.Text == string.Empty || ConfirmPasswordInput.Text == ConfirmPasswordText)
            {
                ConfirmPasswordInput.Focus();
                return;
            }
            SignupUser();
        }
        private void SignupLblBtn_Click(object sender, EventArgs e) => SignupUser();
        void SignupUser()
        {
            if (!ValidateInputs())
            {
               MessageBox.Show("Your inputs are incorrect, remember that:\nPasswords must match \nUsername and password must be between 8 and 20 characters\nUsername and password cannot be empty");
                return;
            }
            if (UserManager.SignUpUser(UsernameInput.Text, PasswordInput.Text, EducatorCheck.Checked)) 
            {
                var result = MessageBox.Show("Add payment information?", "Confirm", MessageBoxButtons.OKCancel);
                if (result == DialogResult.Cancel || result == DialogResult.Abort)
                {
                    Close(); 
                    return;
                }
                Globals.MainForm.ShowPaymentInformation(this);
                
            }

        }
        bool ValidateInputs() =>
            (UsernameInput.Text.Count() > 8) && (UsernameInput.Text.Count() < 20) &&
            (PasswordInput.Text.Count() > 8) && (PasswordInput.Text.Count() < 20) &&
            (PasswordInput.Text == ConfirmPasswordInput.Text);




        private void LoginButton_Click(object sender, EventArgs e) => Globals.MainForm.ShowLogin(this);
    }
}
