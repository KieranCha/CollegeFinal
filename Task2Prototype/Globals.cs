using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2Prototype.Objects;
using Task2Prototype.Managers;

namespace Task2Prototype
{
    static class Globals
    {
        public static MainForm MainForm;
        static CurrentUser _CurrentUser;
        public static CurrentUser CurrentUser 
        { 
            get { return _CurrentUser;  }
            set
            {
                _CurrentUser = value;
                MainForm.UpdateControls(); // update form
            } 
        }

    }
}
