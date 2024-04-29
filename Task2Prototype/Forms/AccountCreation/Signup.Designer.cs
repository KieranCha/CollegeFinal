namespace Task2Prototype.Forms.AccountCreation
{
    partial class Signup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SignupLblBtn = new System.Windows.Forms.Label();
            this.PasswordInput = new System.Windows.Forms.TextBox();
            this.UsernameInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ConfirmPasswordInput = new System.Windows.Forms.TextBox();
            this.EducatorCheck = new System.Windows.Forms.CheckBox();
            this.LoginButton = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Purple;
            this.label3.Location = new System.Drawing.Point(219, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Zoo | Adventures | Hotel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Purple;
            this.label2.Location = new System.Drawing.Point(215, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 39);
            this.label2.TabIndex = 7;
            this.label2.Text = "Adventures";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(230, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 39);
            this.label1.TabIndex = 6;
            this.label1.Text = "Regit Zoo ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SignupLblBtn
            // 
            this.SignupLblBtn.AutoSize = true;
            this.SignupLblBtn.BackColor = System.Drawing.Color.Purple;
            this.SignupLblBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SignupLblBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignupLblBtn.ForeColor = System.Drawing.Color.White;
            this.SignupLblBtn.Location = new System.Drawing.Point(356, 277);
            this.SignupLblBtn.Name = "SignupLblBtn";
            this.SignupLblBtn.Size = new System.Drawing.Size(85, 25);
            this.SignupLblBtn.TabIndex = 13;
            this.SignupLblBtn.Text = "Signup";
            this.SignupLblBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SignupLblBtn.Click += new System.EventHandler(this.SignupLblBtn_Click);
            // 
            // PasswordInput
            // 
            this.PasswordInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordInput.Location = new System.Drawing.Point(189, 181);
            this.PasswordInput.Name = "PasswordInput";
            this.PasswordInput.Size = new System.Drawing.Size(235, 26);
            this.PasswordInput.TabIndex = 12;
            this.PasswordInput.Text = "Password";
            this.PasswordInput.Enter += new System.EventHandler(this.PasswordInput_Enter);
            this.PasswordInput.Leave += new System.EventHandler(this.PasswordInput_Leave);
            // 
            // UsernameInput
            // 
            this.UsernameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameInput.Location = new System.Drawing.Point(189, 140);
            this.UsernameInput.Name = "UsernameInput";
            this.UsernameInput.Size = new System.Drawing.Size(235, 26);
            this.UsernameInput.TabIndex = 11;
            this.UsernameInput.Text = "Username";
            this.UsernameInput.Enter += new System.EventHandler(this.UsernameInput_Enter);
            this.UsernameInput.Leave += new System.EventHandler(this.UsernameInput_Leave);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Purple;
            this.label4.Location = new System.Drawing.Point(171, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(270, 176);
            this.label4.TabIndex = 10;
            // 
            // ConfirmPasswordInput
            // 
            this.ConfirmPasswordInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmPasswordInput.Location = new System.Drawing.Point(189, 225);
            this.ConfirmPasswordInput.Name = "ConfirmPasswordInput";
            this.ConfirmPasswordInput.Size = new System.Drawing.Size(235, 26);
            this.ConfirmPasswordInput.TabIndex = 14;
            this.ConfirmPasswordInput.Text = "Confirm Password";
            this.ConfirmPasswordInput.Enter += new System.EventHandler(this.ConfirmPasswordInput_Enter);
            this.ConfirmPasswordInput.Leave += new System.EventHandler(this.ConfirmPasswordInput_Leave);
            // 
            // EducatorCheck
            // 
            this.EducatorCheck.AutoSize = true;
            this.EducatorCheck.BackColor = System.Drawing.Color.Purple;
            this.EducatorCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EducatorCheck.ForeColor = System.Drawing.Color.White;
            this.EducatorCheck.Location = new System.Drawing.Point(189, 258);
            this.EducatorCheck.Name = "EducatorCheck";
            this.EducatorCheck.Size = new System.Drawing.Size(102, 24);
            this.EducatorCheck.TabIndex = 15;
            this.EducatorCheck.Text = "Educator?";
            this.EducatorCheck.UseVisualStyleBackColor = false;
            // 
            // LoginButton
            // 
            this.LoginButton.AutoSize = true;
            this.LoginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginButton.ForeColor = System.Drawing.Color.Purple;
            this.LoginButton.Location = new System.Drawing.Point(171, 302);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(182, 13);
            this.LoginButton.TabIndex = 16;
            this.LoginButton.Text = "Already have an account? Click here";
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 330);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.EducatorCheck);
            this.Controls.Add(this.ConfirmPasswordInput);
            this.Controls.Add(this.SignupLblBtn);
            this.Controls.Add(this.PasswordInput);
            this.Controls.Add(this.UsernameInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Signup";
            this.Text = "Signup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label SignupLblBtn;
        private System.Windows.Forms.TextBox PasswordInput;
        private System.Windows.Forms.TextBox UsernameInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ConfirmPasswordInput;
        private System.Windows.Forms.CheckBox EducatorCheck;
        private System.Windows.Forms.Label LoginButton;
    }
}