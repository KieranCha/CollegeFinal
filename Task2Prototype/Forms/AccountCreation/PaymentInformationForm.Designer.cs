namespace Task2Prototype.Forms.AccountCreation
{
    partial class PaymentInformationForm
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
            this.CardNumberInput = new System.Windows.Forms.TextBox();
            this.CVVinput = new System.Windows.Forms.TextBox();
            this.ExpiryDateInput = new System.Windows.Forms.TextBox();
            this.CardHolderNameInput = new System.Windows.Forms.TextBox();
            this.ConfirmPaymentLblBtn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Purple;
            this.label3.Location = new System.Drawing.Point(290, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Zoo | Adventures | Hotel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Purple;
            this.label2.Location = new System.Drawing.Point(286, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 39);
            this.label2.TabIndex = 10;
            this.label2.Text = "Adventures";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(301, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 39);
            this.label1.TabIndex = 9;
            this.label1.Text = "Regit Zoo ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Purple;
            this.label4.Location = new System.Drawing.Point(241, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(270, 128);
            this.label4.TabIndex = 12;
            // 
            // CardNumberInput
            // 
            this.CardNumberInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CardNumberInput.Location = new System.Drawing.Point(256, 129);
            this.CardNumberInput.Name = "CardNumberInput";
            this.CardNumberInput.Size = new System.Drawing.Size(240, 26);
            this.CardNumberInput.TabIndex = 13;
            this.CardNumberInput.Text = "Card Number";
            this.CardNumberInput.TextChanged += new System.EventHandler(this.TextChanged);
            this.CardNumberInput.Enter += new System.EventHandler(this.CardNumberFocus);
            this.CardNumberInput.Leave += new System.EventHandler(this.CardNumberUnfocus);
            // 
            // CVVinput
            // 
            this.CVVinput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CVVinput.Location = new System.Drawing.Point(256, 161);
            this.CVVinput.Name = "CVVinput";
            this.CVVinput.Size = new System.Drawing.Size(75, 26);
            this.CVVinput.TabIndex = 14;
            this.CVVinput.Text = "CVV";
            this.CVVinput.TextChanged += new System.EventHandler(this.TextChanged);
            this.CVVinput.Enter += new System.EventHandler(this.CVVtextFocus);
            this.CVVinput.Leave += new System.EventHandler(this.CVVtextUnfocus);
            // 
            // ExpiryDateInput
            // 
            this.ExpiryDateInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpiryDateInput.Location = new System.Drawing.Point(407, 161);
            this.ExpiryDateInput.Name = "ExpiryDateInput";
            this.ExpiryDateInput.Size = new System.Drawing.Size(89, 26);
            this.ExpiryDateInput.TabIndex = 15;
            this.ExpiryDateInput.Text = "Expiry Date";
            this.ExpiryDateInput.TextChanged += new System.EventHandler(this.TextChanged);
            this.ExpiryDateInput.Enter += new System.EventHandler(this.ExpiryDateFocus);
            this.ExpiryDateInput.Leave += new System.EventHandler(this.ExpiryDateUnfocus);
            // 
            // CardHolderNameInput
            // 
            this.CardHolderNameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CardHolderNameInput.Location = new System.Drawing.Point(256, 193);
            this.CardHolderNameInput.Name = "CardHolderNameInput";
            this.CardHolderNameInput.Size = new System.Drawing.Size(240, 26);
            this.CardHolderNameInput.TabIndex = 16;
            this.CardHolderNameInput.Text = "Card Holders Full Name";
            this.CardHolderNameInput.TextChanged += new System.EventHandler(this.TextChanged);
            this.CardHolderNameInput.Enter += new System.EventHandler(this.HolderNameFocus);
            this.CardHolderNameInput.Leave += new System.EventHandler(this.HolderNameUnfocus);
            // 
            // ConfirmPaymentLblBtn
            // 
            this.ConfirmPaymentLblBtn.BackColor = System.Drawing.Color.Purple;
            this.ConfirmPaymentLblBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConfirmPaymentLblBtn.Enabled = false;
            this.ConfirmPaymentLblBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmPaymentLblBtn.ForeColor = System.Drawing.Color.White;
            this.ConfirmPaymentLblBtn.Location = new System.Drawing.Point(239, 250);
            this.ConfirmPaymentLblBtn.Name = "ConfirmPaymentLblBtn";
            this.ConfirmPaymentLblBtn.Size = new System.Drawing.Size(272, 25);
            this.ConfirmPaymentLblBtn.TabIndex = 17;
            this.ConfirmPaymentLblBtn.Text = "Confirm Payment Info";
            this.ConfirmPaymentLblBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ConfirmPaymentLblBtn.Click += new System.EventHandler(this.ConfirmPaymentLblBtn_Click);
            // 
            // PaymentInformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ConfirmPaymentLblBtn);
            this.Controls.Add(this.CardHolderNameInput);
            this.Controls.Add(this.ExpiryDateInput);
            this.Controls.Add(this.CVVinput);
            this.Controls.Add(this.CardNumberInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PaymentInformationForm";
            this.Text = "PaymentInformationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CardNumberInput;
        private System.Windows.Forms.TextBox CVVinput;
        private System.Windows.Forms.TextBox ExpiryDateInput;
        private System.Windows.Forms.TextBox CardHolderNameInput;
        private System.Windows.Forms.Label ConfirmPaymentLblBtn;
    }
}