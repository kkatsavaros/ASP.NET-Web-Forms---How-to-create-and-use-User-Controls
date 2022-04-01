using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _43.User_Controls
{
    public partial class CalendarUserControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Calendar1.Visible = false;
            }
        }


        protected void ImgBtn_Click(object sender, ImageClickEventArgs e)
        {
            if (Calendar1.Visible)
            {
                Calendar1.Visible = false;
            }
            else
            {
                Calendar1.Visible = true;
            }
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            txtDate.Text = Calendar1.SelectedDate.ToShortDateString();
            Calendar1.Visible = false;
        }

        // SelectedDate property, χωρίς παρανθέσεις.
        public string SelectedDate3
        {
            get { return txtDate.Text; }    // Θα βγάλει την τιμή από το TextBox.

            set { txtDate.Text = value; }   // Θα πάρει την τιμή από το TextBox
        }        

    }


    public class CalendarVisibilityChangedEventArgs
    {
        private bool _isCalendarVisible; // That is a boolean field.

        // Για να το εξάγουμε στον έξω κόσμο χρειαζόμαστε μία public property.
        public bool IsCalendarVisible
        {
            get
            {
                return _isCalendarVisible;
            }
        }

        // Constructor for that
        public CalendarVisibilityChangedEventArgs(bool IsCalendarVisible)
        {
            _isCalendarVisible = IsCalendarVisible;
        }



    }
}