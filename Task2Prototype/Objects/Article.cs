using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2Prototype.Objects
{
    public class Article
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Content { get; set; }
        public bool EducatorExclusive { get; set; }
    }
    
    public class ArticleSearchResult
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int ArticleID { get; set; }
        public bool EducatorExclusive { get; set; }
        public string TextPreview { get; set; }

        public Article GetFullArticle() => DatabaseManager.Get<Article>(this.ArticleID);
    }
}
