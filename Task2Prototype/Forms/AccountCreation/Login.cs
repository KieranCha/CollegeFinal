using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task2Prototype.Managers;

namespace Task2Prototype.Forms
{
    public partial class Login : Form
    {
        const string PasswordText = "Password";
        const string UsernameText = "Username";
        public Login()
        {
            InitializeComponent();
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

        // Login logic
        private void EnterKeyPressed(object sender, KeyPressEventArgs key)
        {
            // QOL, if you press enter on one of the inputs it'll either
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
            LoginUser();
        }
        private void LoginLblBtn_Click(object sender, EventArgs e) => LoginUser();

        void LoginUser()
        {
            if (UsernameInput.Text == UsernameText || PasswordInput.Text == PasswordText) return;
            if (UserManager.LoginUser(UsernameInput.Text, PasswordInput.Text)) Close();
            else MessageBox.Show("Password or username incorrect!");

        }

        private void SignUpButton_Click(object sender, EventArgs e) => Globals.MainForm.ShowSignup(this);


        // take focus from username input 
        private void Login_Load(object sender, EventArgs e) => this.ActiveControl = label1;
    }
}
