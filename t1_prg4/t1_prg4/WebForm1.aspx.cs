using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace t1_prg4
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindData();
            }
        }

        private void BindData()
        {
            // Create a DataTable to hold the data
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Name");
            dt.Columns.Add("Salary");

            // Add rows to the DataTable
            dt.Rows.Add("100", "Rishab", "7000");
            dt.Rows.Add("101", "Dharani", "7800");
            dt.Rows.Add("102", "Joseph", "8500");
            dt.Rows.Add("103", "Yamuna", "9500");

            // Bind the DataTable to the GridView
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
    }
}
    