namespace Task2Prototype.Custom_Controls
{
    partial class BookingControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label4 = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.TicketDisplay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Purple;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(-3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(329, 67);
            this.label4.TabIndex = 11;
            this.label4.Text = "Booking";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // DateLabel
            // 
            this.DateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel.Location = new System.Drawing.Point(3, 31);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(318, 24);
            this.DateLabel.TabIndex = 12;
            this.DateLabel.Text = "Date => Date";
            // 
            // TicketDisplay
            // 
            this.TicketDisplay.AutoSize = true;
            this.TicketDisplay.BackColor = System.Drawing.Color.Purple;
            this.TicketDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TicketDisplay.ForeColor = System.Drawing.Color.White;
            this.TicketDisplay.Location = new System.Drawing.Point(229, 4);
            this.TicketDisplay.Name = "TicketDisplay";
            this.TicketDisplay.Size = new System.Drawing.Size(63, 20);
            this.TicketDisplay.TabIndex = 13;
            this.TicketDisplay.Text = "Tickets:";
            // 
            // BookingControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TicketDisplay);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.label4);
            this.Name = "BookingControl";
            this.Size = new System.Drawing.Size(324, 67);
            this.Load += new System.EventHandler(this.BookingControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Label TicketDisplay;
    }
}
