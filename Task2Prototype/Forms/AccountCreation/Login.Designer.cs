namespace Task2Prototype.Forms
{
    partial class Login
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
            this.label4 = new System.Windows.Forms.Label();
            this.UsernameInput = new System.Windows.Forms.TextBox();
            this.PasswordInput = new System.Windows.Forms.TextBox();
            this.LoginLblBtn = new System.Windows.Forms.Label();
            this.SignUpButton = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Purple;
            this.label3.Location = new System.Drawing.Point(209, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Zoo | Adventures | Hotel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Purple;
            this.label2.Location = new System.Drawing.Point(205, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 39);
            this.label2.TabIndex = 4;
            this.label2.Text = "Adventures";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(220, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "Regit Zoo ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Purple;
            this.label4.Location = new System.Drawing.Point(162, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(270, 139);
            this.label4.TabIndex = 6;
            // 
            // UsernameInput
            // 
            this.UsernameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameInput.Location = new System.Drawing.Point(180, 133);
            this.UsernameInput.Name = "UsernameInput";
            this.UsernameInput.Size = new System.Drawing.Size(235, 26);
            this.UsernameInput.TabIndex = 7;
            this.UsernameInput.Text = "Username";
            this.UsernameInput.Enter += new System.EventHandler(this.UsernameInput_Enter);
            this.UsernameInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterKeyPressed);
            this.UsernameInput.Leave += new System.EventHandler(this.UsernameInput_Leave);
            // 
            // PasswordInput
            // 
            this.PasswordInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordInput.Location = new System.Drawing.Point(180, 174);
            this.PasswordInput.Name = "PasswordInput";
            this.PasswordInput.Size = new System.Drawing.Size(235, 26);
            this.PasswordInput.TabIndex = 8;
            this.PasswordInput.Text = "Password";
            this.PasswordInput.Enter += new System.EventHandler(this.PasswordInput_Enter);
            this.PasswordInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterKeyPressed);
            this.PasswordInput.Leave += new System.EventHandler(this.PasswordInput_Leave);
            // 
            // LoginLblBtn
            // 
            this.LoginLblBtn.AutoSize = true;
            this.LoginLblBtn.BackColor = System.Drawing.Color.Purple;
            this.LoginLblBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginLblBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginLblBtn.ForeColor = System.Drawing.Color.White;
            this.LoginLblBtn.Location = new System.Drawing.Point(362, 233);
            this.LoginLblBtn.Name = "LoginLblBtn";
            this.LoginLblBtn.Size = new System.Drawing.Size(70, 25);
            this.LoginLblBtn.TabIndex = 9;
            this.LoginLblBtn.Text = "Login";
            this.LoginLblBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LoginLblBtn.Click += new System.EventHandler(this.LoginLblBtn_Click);
            // 
            // SignUpButton
            // 
            this.SignUpButton.AutoSize = true;
            this.SignUpButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SignUpButton.ForeColor = System.Drawing.Color.Purple;
            this.SignUpButton.Location = new System.Drawing.Point(162, 258);
            this.SignUpButton.Name = "SignUpButton";
            this.SignUpButton.Size = new System.Drawing.Size(120, 13);
            this.SignUpButton.TabIndex = 10;
            this.SignUpButton.Text = "No Account? Click here";
            this.SignUpButton.Click += new System.EventHandler(this.SignUpButton_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 310);
            this.Controls.Add(this.SignUpButton);
            this.Controls.Add(this.LoginLblBtn);
            this.Controls.Add(this.PasswordInput);
            this.Controls.Add(this.UsernameInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox UsernameInput;
        private System.Windows.Forms.TextBox PasswordInput;
        private System.Windows.Forms.Label LoginLblBtn;
        private System.Windows.Forms.Label SignUpButton;
    }
}