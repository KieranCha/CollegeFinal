using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task2Prototype.Objects;

namespace Task2Prototype
{
    public partial class ArticleControl : UserControl
    {
        public ArticleSearchResult Article = null;
        public ArticleControl()
        {
            InitializeComponent();
        }

        public void SetArticle(ArticleSearchResult article)
        {
            Article = article;
            AuthorLabel.Text = $"By {Article.Author}";
            ArticleTitle.Text = Article.Title;
            ArticleTextPreview.Text = Article.TextPreview;
        }
        private void ReadMoreBtn_Click(object sender, EventArgs e)
        {
            // need form for article display!!!!
        }
    }
}
