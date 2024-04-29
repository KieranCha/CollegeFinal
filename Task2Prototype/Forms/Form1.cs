using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task2Prototype.Forms;
using Task2Prototype.Forms.AccountCreation;
using Task2Prototype.Managers;
using Task2Prototype.Objects;

namespace Task2Prototype
{
    public partial class MainForm : Form
    {
        // home page values
        int POPULAR_ARTICLE_PAGE_SIZE;
        // search page values
        string SearchBarPlaceholderTxt = "Click here to search...";
        int _CurrentPage {
            get { return CurrentPage; } 
            set { CurrentPage = value; RefreshArticles(); } }
        int CurrentPage = 1;
        int SEARCH_PAGE_SIZE;
        int currentArticlesCount;
        ArticleFilter CurrentFilter = ArticleFilter.None;
        public MainForm()
        {
            InitializeComponent();
        }
        private void OnLoad(object sender, EventArgs e)
        {
            UpdateControls(); // update stuff :p
        }

        public void UpdateControls()
        {
            // set "const" values, not really constants cause they're set during runtime
            SEARCH_PAGE_SIZE = SearchResultsBox.Controls.Cast<Control>().Where(x => x.GetType() == typeof(ArticleControl)).Count();
            POPULAR_ARTICLE_PAGE_SIZE = HomePage.Controls.Cast<Control>().Where(x => x.GetType() == typeof(ArticleControl)).Count();
            // set global value
            Globals.MainForm = this;
            // add throttle to event, could do this in designer but editing designer can break code unexpectedly
            SearchBar.TextChanged += CreateThrottledEventHandler(TimeSpan.FromMilliseconds(500)); // throttle event handler to prevent calling it too much
            // unfocus from textbox
            this.ActiveControl = label1;
            // set action button states
            LoginToggleLabel.Text = (Globals.CurrentUser == null) ? "Login" : "Logout";
            BookingLblButton.Enabled = Globals.CurrentUser?.PaymentLinked ?? false;
            // "Manage Bookings" Label
            label10.Enabled = Globals.CurrentUser?.HasBookings ?? false;
            // "Education Articles" Label
            label9.Enabled = Globals.CurrentUser?.Educator ?? false;
            // "Account" Label
            label7.Enabled = Globals.CurrentUser != null;
            // align groupboxes
            HomePage.Location = SearchResultsBox.Location;
            // set popular articles
            RefreshPopularArticles();
        }
        

        // Search bar and article search Logic
        private void SearchBar_Enter(object sender, EventArgs e)
        {
            SearchBar.Text = (SearchBar.Text == SearchBarPlaceholderTxt) ? string.Empty : SearchBar.Text;
            HomePage.Visible = false;
            SearchResultsBox.Visible = true;
            GoBackLabel.Visible = true;
        }
        private void SearchBar_Leave(object sender, EventArgs e) => SearchBar.Text = (SearchBar.Text == string.Empty) ? SearchBarPlaceholderTxt : SearchBar.Text;
        private void SearchBar_TextChanged(object sender, EventArgs e) // throttled
        {
            CurrentPage = 1;
            if (SearchBar.Text == SearchBarPlaceholderTxt) return;
            RefreshArticles();
        }
        void RefreshArticles()
        {
            List<ArticleSearchResult> Articles = DatabaseManager.GetArticles(
                (SearchBar.Text == string.Empty || SearchBar.Text == SearchBarPlaceholderTxt) ? "*" : SearchBar.Text,
                CurrentFilter,
                CurrentPage,
                SEARCH_PAGE_SIZE
                );
            // this should go through each control, if its an Article control, give it an article
            int currentIndex = 0;
            SearchResultsBox.Controls.Cast<Control>().ToList().ForEach(x =>
            {
                if (x.GetType() == typeof(ArticleControl)) 
                {
                    try {
                        x.Visible = true; // if an article was previously empty and made invisible, make it visible now
                        ((ArticleControl)x).SetArticle(Articles[currentIndex]); 
                    }
                    catch(ArgumentOutOfRangeException) { x.Visible = false; } // if we run out of articles, simply make controls w/o
                    currentIndex++;                                        // An article invisible
                }
            });
            // set button state
            currentArticlesCount = Articles.Count;
            PrvPageBtn.Enabled = (_CurrentPage > 1);
            NxtPageBtn.Enabled = (currentArticlesCount == SEARCH_PAGE_SIZE);
        }
        
        // Home Page logic
        private void GoBackHome(object sender, EventArgs e)
        {
            SearchResultsBox.Visible = false;
            HomePage.Visible = true;
            GoBackLabel.Visible = false;
            this.ActiveControl = label1; //unfocus from textbox
            RefreshPopularArticles();
        }

        private void RefreshPopularArticles()
        {
            Random rand = new Random(); // used to get random page for pop articles
            List<ArticleSearchResult> Articles = DatabaseManager.GetArticles(
                "*",
                (Globals.CurrentUser?.Educator ?? false) ? ArticleFilter.None : ArticleFilter.ExcludeEducatorExclusive,
                rand.Next(1, (int)Math.Truncate((decimal)(DatabaseManager.GetTotalArticles() / POPULAR_ARTICLE_PAGE_SIZE))), // get the total number of pages by getting the total number of articles and dividing by page size
                POPULAR_ARTICLE_PAGE_SIZE
                );
            // prevent less than 4 from appearing
            if (Articles.Count < POPULAR_ARTICLE_PAGE_SIZE)
            {
                RefreshPopularArticles(); // in theory, if someones unlucky enough, this could on forever/ extended period of time
                return;
            }
            // this should go through each control, if its an Article control, give it an article
            int currentIndex = 0;
            HomePage.Controls.Cast<Control>().ToList().ForEach(x =>
            {
                if (x.GetType() == typeof(ArticleControl))
                {
                    try
                    {
                        x.Visible = true; // if an article was previously empty and made invisible, make it visible now
                        ((ArticleControl)x).SetArticle(Articles[currentIndex]);
                    }
                    catch (ArgumentOutOfRangeException) { x.Visible = false; } // if we run out of articles, simply make controls w/o
                    currentIndex++;                                        // An article invisible
                }
            });
        }

        // Throttling event handler from, edited to remove event thats excuted when orginal event is called while throttled
        // https://stackoverflow.com/a/21404072
        private EventHandler CreateThrottledEventHandler(TimeSpan throttle)
        {
            bool throttling = false;
            return (s, e) =>
            {
                if (throttling) return; 
                throttling = true;
                Task.Delay(throttle).ContinueWith(_ => throttling = false);
            };
        }

        private void NxtPageBtn_Click(object sender, EventArgs e) => _CurrentPage++;
        private void PrvPageBtn_Click(object sender, EventArgs e) => _CurrentPage--;

        public void ShowSignup(Form cameFrom = null)
        {
            // open dialogs here so the ones they came from can be closed without making the opened one close
            // this should also help with too many forms from being open
            if (cameFrom != null) cameFrom.Close();
            Signup form = new Signup();
            form.Show();
        }

        public void ShowLogin(Form cameFrom = null)
        {
            if (cameFrom != null) cameFrom.Close();
            Login form = new Login();
            form.Show();
        }

        public void ShowPaymentInformation(Form cameFrom = null)
        {
            if (cameFrom != null) cameFrom.Close(); 
            PaymentInformationForm form = new PaymentInformationForm();
            form.Show();
        }

        private void LoginToggleLabel_Click(object sender, EventArgs e)
        {
            if (Globals.CurrentUser == null) ShowLogin();
            else UserManager.LogOutUser();
        }

        private void BookingLblButton_Click(object sender, EventArgs e)
        {
            
            if (!Globals.CurrentUser.HasBookings)
            {
                // should be called bookingcreateform but no time to change
                BookingManager bookingManager = new BookingManager();
                bookingManager.ShowDialog();
            }

        }

        // "Manage bookings" button
        private void label10_Click(object sender, EventArgs e)
        {
            BookingViewer bookingViewer = new BookingViewer();
            bookingViewer.ShowDialog();
        }

        // "Educational Articles" button
        private void label9_Click(object sender, EventArgs e)
        {
            CurrentFilter = ArticleFilter.EducatorExclusiveOnly;
            SearchBar.Focus();
        }

        // "Account" button
        private void label7_Click(object sender, EventArgs e)
        {
            AccountManager accountManager = new AccountManager();
            accountManager.ShowDialog();
        }
    }
}
