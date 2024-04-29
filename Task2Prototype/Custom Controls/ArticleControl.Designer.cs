namespace Task2Prototype
{
    partial class ArticleControl
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
            this.ArticleTitle = new System.Windows.Forms.Label();
            this.ArticleTextPreview = new System.Windows.Forms.Label();
            this.ReadMoreBtn = new System.Windows.Forms.Label();
            this.AuthorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ArticleTitle
            // 
            this.ArticleTitle.BackColor = System.Drawing.Color.Purple;
            this.ArticleTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArticleTitle.ForeColor = System.Drawing.Color.White;
            this.ArticleTitle.Location = new System.Drawing.Point(0, 0);
            this.ArticleTitle.Name = "ArticleTitle";
            this.ArticleTitle.Size = new System.Drawing.Size(150, 29);
            this.ArticleTitle.TabIndex = 0;
            this.ArticleTitle.Text = "ArticleTitle";
            // 
            // ArticleTextPreview
            // 
            this.ArticleTextPreview.AutoEllipsis = true;
            this.ArticleTextPreview.BackColor = System.Drawing.Color.White;
            this.ArticleTextPreview.Location = new System.Drawing.Point(3, 45);
            this.ArticleTextPreview.Name = "ArticleTextPreview";
            this.ArticleTextPreview.Size = new System.Drawing.Size(144, 79);
            this.ArticleTextPreview.TabIndex = 1;
            this.ArticleTextPreview.Text = "Text preview";
            // 
            // ReadMoreBtn
            // 
            this.ReadMoreBtn.BackColor = System.Drawing.Color.White;
            this.ReadMoreBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReadMoreBtn.Location = new System.Drawing.Point(3, 124);
            this.ReadMoreBtn.Name = "ReadMoreBtn";
            this.ReadMoreBtn.Size = new System.Drawing.Size(144, 23);
            this.ReadMoreBtn.TabIndex = 2;
            this.ReadMoreBtn.Text = "Read More";
            this.ReadMoreBtn.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // AuthorLabel
            // 
            this.AuthorLabel.BackColor = System.Drawing.Color.White;
            this.AuthorLabel.Location = new System.Drawing.Point(3, 29);
            this.AuthorLabel.Name = "AuthorLabel";
            this.AuthorLabel.Size = new System.Drawing.Size(144, 16);
            this.AuthorLabel.TabIndex = 3;
            this.AuthorLabel.Text = "By Author";
            // 
            // ArticleControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.Controls.Add(this.AuthorLabel);
            this.Controls.Add(this.ReadMoreBtn);
            this.Controls.Add(this.ArticleTextPreview);
            this.Controls.Add(this.ArticleTitle);
            this.Name = "ArticleControl";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label ArticleTitle;
        private System.Windows.Forms.Label ArticleTextPreview;
        private System.Windows.Forms.Label ReadMoreBtn;
        private System.Windows.Forms.Label AuthorLabel;
    }
}
