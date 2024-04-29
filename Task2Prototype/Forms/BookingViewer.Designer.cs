namespace Task2Prototype.Forms
{
    partial class BookingViewer
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
            this.bookingControl6 = new Task2Prototype.Custom_Controls.BookingControl();
            this.bookingControl5 = new Task2Prototype.Custom_Controls.BookingControl();
            this.bookingControl3 = new Task2Prototype.Custom_Controls.BookingControl();
            this.bookingControl2 = new Task2Prototype.Custom_Controls.BookingControl();
            this.bookingControl1 = new Task2Prototype.Custom_Controls.BookingControl();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bookings";
            // 
            // bookingControl6
            // 
            this.bookingControl6.Location = new System.Drawing.Point(12, 33);
            this.bookingControl6.Name = "bookingControl6";
            this.bookingControl6.Size = new System.Drawing.Size(324, 67);
            this.bookingControl6.TabIndex = 6;
            // 
            // bookingControl5
            // 
            this.bookingControl5.Location = new System.Drawing.Point(12, 106);
            this.bookingControl5.Name = "bookingControl5";
            this.bookingControl5.Size = new System.Drawing.Size(324, 67);
            this.bookingControl5.TabIndex = 5;
            // 
            // bookingControl3
            // 
            this.bookingControl3.Location = new System.Drawing.Point(12, 179);
            this.bookingControl3.Name = "bookingControl3";
            this.bookingControl3.Size = new System.Drawing.Size(324, 67);
            this.bookingControl3.TabIndex = 4;
            // 
            // bookingControl2
            // 
            this.bookingControl2.Location = new System.Drawing.Point(12, 252);
            this.bookingControl2.Name = "bookingControl2";
            this.bookingControl2.Size = new System.Drawing.Size(324, 67);
            this.bookingControl2.TabIndex = 3;
            // 
            // bookingControl1
            // 
            this.bookingControl1.Location = new System.Drawing.Point(12, 325);
            this.bookingControl1.Name = "bookingControl1";
            this.bookingControl1.Size = new System.Drawing.Size(324, 67);
            this.bookingControl1.TabIndex = 2;
            // 
            // BookingViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 401);
            this.Controls.Add(this.bookingControl6);
            this.Controls.Add(this.bookingControl5);
            this.Controls.Add(this.bookingControl3);
            this.Controls.Add(this.bookingControl2);
            this.Controls.Add(this.bookingControl1);
            this.Controls.Add(this.label1);
            this.Name = "BookingViewer";
            this.Text = "BookingViewer";
            this.Load += new System.EventHandler(this.BookingViewer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private Custom_Controls.BookingControl bookingControl1;
        private Custom_Controls.BookingControl bookingControl2;
        private Custom_Controls.BookingControl bookingControl3;
        private Custom_Controls.BookingControl bookingControl5;
        private Custom_Controls.BookingControl bookingControl6;
    }
}