namespace Task2Prototype.Forms
{
    partial class AccountManager
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
            this.NameLbl = new System.Windows.Forms.Label();
            this.PaymentInfoBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLbl.Location = new System.Drawing.Point(13, 13);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(51, 20);
            this.NameLbl.TabIndex = 0;
            this.NameLbl.Text = "Name";
            // 
            // PaymentInfoBtn
            // 
            this.PaymentInfoBtn.Location = new System.Drawing.Point(12, 51);
            this.PaymentInfoBtn.Name = "PaymentInfoBtn";
            this.PaymentInfoBtn.Size = new System.Drawing.Size(159, 23);
            this.PaymentInfoBtn.TabIndex = 1;
            this.PaymentInfoBtn.Text = "Add Payment Information";
            this.PaymentInfoBtn.UseVisualStyleBackColor = true;
            this.PaymentInfoBtn.Click += new System.EventHandler(this.PaymentInfoBtn_Click);
            // 
            // AccountManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(183, 86);
            this.Controls.Add(this.PaymentInfoBtn);
            this.Controls.Add(this.NameLbl);
            this.Name = "AccountManager";
            this.Text = "AccountManager";
            this.Load += new System.EventHandler(this.AccountManager_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.Button PaymentInfoBtn;
    }
}