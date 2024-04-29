namespace Task2Prototype
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SearchBar = new System.Windows.Forms.TextBox();
            this.HomePage = new System.Windows.Forms.GroupBox();
            this.LoginToggleLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.BookingLblButton = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SearchResultsBox = new System.Windows.Forms.GroupBox();
            this.PrvPageBtn = new System.Windows.Forms.Button();
            this.NxtPageBtn = new System.Windows.Forms.Button();
            this.GoBackLabel = new System.Windows.Forms.Label();
            this.articleControl4 = new Task2Prototype.ArticleControl();
            this.articleControl3 = new Task2Prototype.ArticleControl();
            this.articleControl1 = new Task2Prototype.ArticleControl();
            this.articleControl2 = new Task2Prototype.ArticleControl();
            this.articleControl8 = new Task2Prototype.ArticleControl();
            this.articleControl7 = new Task2Prototype.ArticleControl();
            this.articleControl6 = new Task2Prototype.ArticleControl();
            this.articleControl5 = new Task2Prototype.ArticleControl();
            this.articleControl9 = new Task2Prototype.ArticleControl();
            this.articleControl10 = new Task2Prototype.ArticleControl();
            this.HomePage.SuspendLayout();
            this.SearchResultsBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(393, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Regit Zoo ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.GoBackHome);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Purple;
            this.label2.Location = new System.Drawing.Point(378, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "Adventures";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.GoBackHome);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Purple;
            this.label3.Location = new System.Drawing.Point(382, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Zoo | Adventures | Hotel";
            this.label3.Click += new System.EventHandler(this.GoBackHome);
            // 
            // SearchBar
            // 
            this.SearchBar.Location = new System.Drawing.Point(211, 111);
            this.SearchBar.Name = "SearchBar";
            this.SearchBar.Size = new System.Drawing.Size(521, 20);
            this.SearchBar.TabIndex = 4;
            this.SearchBar.Text = "Click here to search...";
            this.SearchBar.TextChanged += new System.EventHandler(this.SearchBar_TextChanged);
            this.SearchBar.Enter += new System.EventHandler(this.SearchBar_Enter);
            this.SearchBar.Leave += new System.EventHandler(this.SearchBar_Leave);
            // 
            // HomePage
            // 
            this.HomePage.Controls.Add(this.LoginToggleLabel);
            this.HomePage.Controls.Add(this.label10);
            this.HomePage.Controls.Add(this.label9);
            this.HomePage.Controls.Add(this.BookingLblButton);
            this.HomePage.Controls.Add(this.label7);
            this.HomePage.Controls.Add(this.label6);
            this.HomePage.Controls.Add(this.label5);
            this.HomePage.Controls.Add(this.label4);
            this.HomePage.Controls.Add(this.articleControl4);
            this.HomePage.Controls.Add(this.articleControl3);
            this.HomePage.Controls.Add(this.articleControl1);
            this.HomePage.Controls.Add(this.articleControl2);
            this.HomePage.Location = new System.Drawing.Point(12, 12);
            this.HomePage.Name = "HomePage";
            this.HomePage.Size = new System.Drawing.Size(522, 399);
            this.HomePage.TabIndex = 5;
            this.HomePage.TabStop = false;
            // 
            // LoginToggleLabel
            // 
            this.LoginToggleLabel.AutoSize = true;
            this.LoginToggleLabel.BackColor = System.Drawing.Color.White;
            this.LoginToggleLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginToggleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginToggleLabel.Location = new System.Drawing.Point(14, 189);
            this.LoginToggleLabel.Name = "LoginToggleLabel";
            this.LoginToggleLabel.Size = new System.Drawing.Size(48, 20);
            this.LoginToggleLabel.TabIndex = 12;
            this.LoginToggleLabel.Text = "Login";
            this.LoginToggleLabel.Click += new System.EventHandler(this.LoginToggleLabel_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(14, 156);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(137, 20);
            this.label10.TabIndex = 11;
            this.label10.Text = "Manage Bookings";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(14, 124);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(149, 20);
            this.label9.TabIndex = 10;
            this.label9.Text = "Educational Articles";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // BookingLblButton
            // 
            this.BookingLblButton.AutoSize = true;
            this.BookingLblButton.BackColor = System.Drawing.Color.White;
            this.BookingLblButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BookingLblButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookingLblButton.Location = new System.Drawing.Point(14, 89);
            this.BookingLblButton.Name = "BookingLblButton";
            this.BookingLblButton.Size = new System.Drawing.Size(67, 20);
            this.BookingLblButton.TabIndex = 9;
            this.BookingLblButton.Text = "Booking";
            this.BookingLblButton.Click += new System.EventHandler(this.BookingLblButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Account";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(9, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(192, 294);
            this.label6.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Purple;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(6, 20);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.label5.Size = new System.Drawing.Size(197, 329);
            this.label5.TabIndex = 6;
            this.label5.Text = "Resources";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(294, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Popular Articles";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SearchResultsBox
            // 
            this.SearchResultsBox.Controls.Add(this.articleControl8);
            this.SearchResultsBox.Controls.Add(this.articleControl7);
            this.SearchResultsBox.Controls.Add(this.articleControl6);
            this.SearchResultsBox.Controls.Add(this.articleControl5);
            this.SearchResultsBox.Controls.Add(this.articleControl9);
            this.SearchResultsBox.Controls.Add(this.articleControl10);
            this.SearchResultsBox.Controls.Add(this.PrvPageBtn);
            this.SearchResultsBox.Controls.Add(this.NxtPageBtn);
            this.SearchResultsBox.Location = new System.Drawing.Point(211, 137);
            this.SearchResultsBox.Name = "SearchResultsBox";
            this.SearchResultsBox.Size = new System.Drawing.Size(521, 378);
            this.SearchResultsBox.TabIndex = 7;
            this.SearchResultsBox.TabStop = false;
            this.SearchResultsBox.Visible = false;
            // 
            // PrvPageBtn
            // 
            this.PrvPageBtn.BackColor = System.Drawing.Color.Purple;
            this.PrvPageBtn.ForeColor = System.Drawing.Color.White;
            this.PrvPageBtn.Location = new System.Drawing.Point(358, 348);
            this.PrvPageBtn.Name = "PrvPageBtn";
            this.PrvPageBtn.Size = new System.Drawing.Size(75, 23);
            this.PrvPageBtn.TabIndex = 7;
            this.PrvPageBtn.Text = "Prior Page";
            this.PrvPageBtn.UseVisualStyleBackColor = false;
            this.PrvPageBtn.Click += new System.EventHandler(this.PrvPageBtn_Click);
            // 
            // NxtPageBtn
            // 
            this.NxtPageBtn.BackColor = System.Drawing.Color.Purple;
            this.NxtPageBtn.ForeColor = System.Drawing.Color.White;
            this.NxtPageBtn.Location = new System.Drawing.Point(435, 348);
            this.NxtPageBtn.Name = "NxtPageBtn";
            this.NxtPageBtn.Size = new System.Drawing.Size(75, 23);
            this.NxtPageBtn.TabIndex = 6;
            this.NxtPageBtn.Text = "Next Page";
            this.NxtPageBtn.UseVisualStyleBackColor = false;
            this.NxtPageBtn.Click += new System.EventHandler(this.NxtPageBtn_Click);
            // 
            // GoBackLabel
            // 
            this.GoBackLabel.AutoSize = true;
            this.GoBackLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GoBackLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoBackLabel.Location = new System.Drawing.Point(209, 96);
            this.GoBackLabel.Name = "GoBackLabel";
            this.GoBackLabel.Size = new System.Drawing.Size(47, 12);
            this.GoBackLabel.TabIndex = 9;
            this.GoBackLabel.Text = "< Go Back";
            this.GoBackLabel.Visible = false;
            this.GoBackLabel.Click += new System.EventHandler(this.GoBackHome);
            // 
            // articleControl4
            // 
            this.articleControl4.BackColor = System.Drawing.Color.Purple;
            this.articleControl4.Location = new System.Drawing.Point(209, 43);
            this.articleControl4.Name = "articleControl4";
            this.articleControl4.Size = new System.Drawing.Size(150, 150);
            this.articleControl4.TabIndex = 4;
            // 
            // articleControl3
            // 
            this.articleControl3.BackColor = System.Drawing.Color.Purple;
            this.articleControl3.Location = new System.Drawing.Point(365, 43);
            this.articleControl3.Name = "articleControl3";
            this.articleControl3.Size = new System.Drawing.Size(150, 150);
            this.articleControl3.TabIndex = 3;
            // 
            // articleControl1
            // 
            this.articleControl1.BackColor = System.Drawing.Color.Purple;
            this.articleControl1.Location = new System.Drawing.Point(209, 199);
            this.articleControl1.Name = "articleControl1";
            this.articleControl1.Size = new System.Drawing.Size(150, 150);
            this.articleControl1.TabIndex = 2;
            // 
            // articleControl2
            // 
            this.articleControl2.BackColor = System.Drawing.Color.Purple;
            this.articleControl2.Location = new System.Drawing.Point(365, 199);
            this.articleControl2.Name = "articleControl2";
            this.articleControl2.Size = new System.Drawing.Size(150, 150);
            this.articleControl2.TabIndex = 1;
            // 
            // articleControl8
            // 
            this.articleControl8.BackColor = System.Drawing.Color.Purple;
            this.articleControl8.Location = new System.Drawing.Point(14, 19);
            this.articleControl8.Name = "articleControl8";
            this.articleControl8.Size = new System.Drawing.Size(150, 150);
            this.articleControl8.TabIndex = 3;
            // 
            // articleControl7
            // 
            this.articleControl7.BackColor = System.Drawing.Color.Purple;
            this.articleControl7.Location = new System.Drawing.Point(189, 19);
            this.articleControl7.Name = "articleControl7";
            this.articleControl7.Size = new System.Drawing.Size(150, 150);
            this.articleControl7.TabIndex = 2;
            // 
            // articleControl6
            // 
            this.articleControl6.BackColor = System.Drawing.Color.Purple;
            this.articleControl6.Location = new System.Drawing.Point(358, 19);
            this.articleControl6.Name = "articleControl6";
            this.articleControl6.Size = new System.Drawing.Size(150, 150);
            this.articleControl6.TabIndex = 1;
            // 
            // articleControl5
            // 
            this.articleControl5.BackColor = System.Drawing.Color.Purple;
            this.articleControl5.Location = new System.Drawing.Point(14, 187);
            this.articleControl5.Name = "articleControl5";
            this.articleControl5.Size = new System.Drawing.Size(150, 150);
            this.articleControl5.TabIndex = 0;
            // 
            // articleControl9
            // 
            this.articleControl9.BackColor = System.Drawing.Color.Purple;
            this.articleControl9.Location = new System.Drawing.Point(189, 187);
            this.articleControl9.Name = "articleControl9";
            this.articleControl9.Size = new System.Drawing.Size(150, 150);
            this.articleControl9.TabIndex = 4;
            // 
            // articleControl10
            // 
            this.articleControl10.BackColor = System.Drawing.Color.Purple;
            this.articleControl10.Location = new System.Drawing.Point(358, 187);
            this.articleControl10.Name = "articleControl10";
            this.articleControl10.Size = new System.Drawing.Size(150, 150);
            this.articleControl10.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 527);
            this.Controls.Add(this.HomePage);
            this.Controls.Add(this.GoBackLabel);
            this.Controls.Add(this.SearchResultsBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchBar);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.OnLoad);
            this.HomePage.ResumeLayout(false);
            this.HomePage.PerformLayout();
            this.SearchResultsBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SearchBar;
        private System.Windows.Forms.GroupBox HomePage;
        private System.Windows.Forms.Label label4;
        private ArticleControl articleControl4;
        private ArticleControl articleControl3;
        private ArticleControl articleControl1;
        private ArticleControl articleControl2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label BookingLblButton;
        private System.Windows.Forms.GroupBox SearchResultsBox;
        private System.Windows.Forms.Button PrvPageBtn;
        private System.Windows.Forms.Button NxtPageBtn;
        private ArticleControl articleControl10;
        private ArticleControl articleControl9;
        private ArticleControl articleControl8;
        private ArticleControl articleControl7;
        private ArticleControl articleControl6;
        private ArticleControl articleControl5;
        private System.Windows.Forms.Label GoBackLabel;
        private System.Windows.Forms.Label LoginToggleLabel;
    }
}

