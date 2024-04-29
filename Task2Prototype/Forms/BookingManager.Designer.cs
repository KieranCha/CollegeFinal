namespace Task2Prototype.Forms
{
    partial class BookingManager
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
            this.StartDateInput = new System.Windows.Forms.TextBox();
            this.EndDateInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ChildTicketDisplay = new System.Windows.Forms.Label();
            this.StandardTicketDisplay = new System.Windows.Forms.Label();
            this.ChildTicketDecrement = new System.Windows.Forms.Label();
            this.StandardTicketDecrement = new System.Windows.Forms.Label();
            this.ChildTicketIncrement = new System.Windows.Forms.Label();
            this.StandardTicketIncrement = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PremiumHotelCheck = new System.Windows.Forms.CheckBox();
            this.StandardHotelCheck = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CreateBookingBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StartDateInput
            // 
            this.StartDateInput.Location = new System.Drawing.Point(12, 31);
            this.StartDateInput.Name = "StartDateInput";
            this.StartDateInput.Size = new System.Drawing.Size(100, 20);
            this.StartDateInput.TabIndex = 0;
            // 
            // EndDateInput
            // 
            this.EndDateInput.Location = new System.Drawing.Point(118, 31);
            this.EndDateInput.Name = "EndDateInput";
            this.EndDateInput.Size = new System.Drawing.Size(100, 20);
            this.EndDateInput.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Zoo Admission";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Child Tickets: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "StandardTickets: ";
            // 
            // ChildTicketDisplay
            // 
            this.ChildTicketDisplay.AutoSize = true;
            this.ChildTicketDisplay.Location = new System.Drawing.Point(81, 98);
            this.ChildTicketDisplay.Name = "ChildTicketDisplay";
            this.ChildTicketDisplay.Size = new System.Drawing.Size(13, 13);
            this.ChildTicketDisplay.TabIndex = 5;
            this.ChildTicketDisplay.Text = "0";
            // 
            // StandardTicketDisplay
            // 
            this.StandardTicketDisplay.AutoSize = true;
            this.StandardTicketDisplay.Location = new System.Drawing.Point(99, 118);
            this.StandardTicketDisplay.Name = "StandardTicketDisplay";
            this.StandardTicketDisplay.Size = new System.Drawing.Size(13, 13);
            this.StandardTicketDisplay.TabIndex = 6;
            this.StandardTicketDisplay.Text = "0";
            // 
            // ChildTicketDecrement
            // 
            this.ChildTicketDecrement.AutoSize = true;
            this.ChildTicketDecrement.Location = new System.Drawing.Point(182, 98);
            this.ChildTicketDecrement.Name = "ChildTicketDecrement";
            this.ChildTicketDecrement.Size = new System.Drawing.Size(13, 13);
            this.ChildTicketDecrement.TabIndex = 7;
            this.ChildTicketDecrement.Text = "<";
            this.ChildTicketDecrement.Click += new System.EventHandler(this.ChildTicketDecrement_Click);
            // 
            // StandardTicketDecrement
            // 
            this.StandardTicketDecrement.AutoSize = true;
            this.StandardTicketDecrement.Location = new System.Drawing.Point(182, 118);
            this.StandardTicketDecrement.Name = "StandardTicketDecrement";
            this.StandardTicketDecrement.Size = new System.Drawing.Size(13, 13);
            this.StandardTicketDecrement.TabIndex = 8;
            this.StandardTicketDecrement.Text = "<";
            this.StandardTicketDecrement.Click += new System.EventHandler(this.StandardTicketDecrement_Click);
            // 
            // ChildTicketIncrement
            // 
            this.ChildTicketIncrement.AutoSize = true;
            this.ChildTicketIncrement.Location = new System.Drawing.Point(202, 98);
            this.ChildTicketIncrement.Name = "ChildTicketIncrement";
            this.ChildTicketIncrement.Size = new System.Drawing.Size(13, 13);
            this.ChildTicketIncrement.TabIndex = 9;
            this.ChildTicketIncrement.Text = ">";
            this.ChildTicketIncrement.Click += new System.EventHandler(this.ChildTicketIncrement_Click);
            // 
            // StandardTicketIncrement
            // 
            this.StandardTicketIncrement.AutoSize = true;
            this.StandardTicketIncrement.Location = new System.Drawing.Point(202, 118);
            this.StandardTicketIncrement.Name = "StandardTicketIncrement";
            this.StandardTicketIncrement.Size = new System.Drawing.Size(13, 13);
            this.StandardTicketIncrement.TabIndex = 10;
            this.StandardTicketIncrement.Text = ">";
            this.StandardTicketIncrement.Click += new System.EventHandler(this.StandardTicketIncrement_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Hotel Selection (Optional)";
            // 
            // PremiumHotelCheck
            // 
            this.PremiumHotelCheck.AutoSize = true;
            this.PremiumHotelCheck.Location = new System.Drawing.Point(12, 168);
            this.PremiumHotelCheck.Name = "PremiumHotelCheck";
            this.PremiumHotelCheck.Size = new System.Drawing.Size(137, 17);
            this.PremiumHotelCheck.TabIndex = 12;
            this.PremiumHotelCheck.Text = "Premium, £49.99 PNPP";
            this.PremiumHotelCheck.UseVisualStyleBackColor = true;
            this.PremiumHotelCheck.CheckedChanged += new System.EventHandler(this.PremiumHotelCheck_CheckedChanged);
            // 
            // StandardHotelCheck
            // 
            this.StandardHotelCheck.AutoSize = true;
            this.StandardHotelCheck.Location = new System.Drawing.Point(12, 191);
            this.StandardHotelCheck.Name = "StandardHotelCheck";
            this.StandardHotelCheck.Size = new System.Drawing.Size(140, 17);
            this.StandardHotelCheck.TabIndex = 13;
            this.StandardHotelCheck.Text = "Standard, £29.99 PNPP";
            this.StandardHotelCheck.UseVisualStyleBackColor = true;
            this.StandardHotelCheck.CheckedChanged += new System.EventHandler(this.StandardHotelCheck_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Date start";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(115, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Date end";
            // 
            // CreateBookingBtn
            // 
            this.CreateBookingBtn.Location = new System.Drawing.Point(12, 214);
            this.CreateBookingBtn.Name = "CreateBookingBtn";
            this.CreateBookingBtn.Size = new System.Drawing.Size(216, 23);
            this.CreateBookingBtn.TabIndex = 16;
            this.CreateBookingBtn.Text = "Create Booking";
            this.CreateBookingBtn.UseVisualStyleBackColor = true;
            this.CreateBookingBtn.Click += new System.EventHandler(this.CreateBookingBtn_Click);
            // 
            // BookingManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 252);
            this.Controls.Add(this.CreateBookingBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.StandardHotelCheck);
            this.Controls.Add(this.PremiumHotelCheck);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.StandardTicketIncrement);
            this.Controls.Add(this.ChildTicketIncrement);
            this.Controls.Add(this.StandardTicketDecrement);
            this.Controls.Add(this.ChildTicketDecrement);
            this.Controls.Add(this.StandardTicketDisplay);
            this.Controls.Add(this.ChildTicketDisplay);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EndDateInput);
            this.Controls.Add(this.StartDateInput);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "BookingManager";
            this.Text = "BookingManager";
            this.Load += new System.EventHandler(this.BookingManager_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox StartDateInput;
        private System.Windows.Forms.TextBox EndDateInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label ChildTicketDisplay;
        private System.Windows.Forms.Label StandardTicketDisplay;
        private System.Windows.Forms.Label ChildTicketDecrement;
        private System.Windows.Forms.Label StandardTicketDecrement;
        private System.Windows.Forms.Label ChildTicketIncrement;
        private System.Windows.Forms.Label StandardTicketIncrement;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox PremiumHotelCheck;
        private System.Windows.Forms.CheckBox StandardHotelCheck;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button CreateBookingBtn;
    }
}