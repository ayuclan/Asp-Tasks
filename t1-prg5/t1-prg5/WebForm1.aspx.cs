using System;

namespace t1_prg5
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lblCurrentTime.Text = DateTime.Now.ToString("dddd, MMMM dd, yyyy, hh tt");
            }
        }
    }
}