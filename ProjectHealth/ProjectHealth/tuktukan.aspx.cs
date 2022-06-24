using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectHealth
{
    public partial class tuktukan : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void home_Click(object sender, EventArgs e)
        {
            Response.Redirect("homepage.aspx");
        }

        protected void tuk_Click(object sender, EventArgs e)
        {
            Response.Redirect("tuktukan.aspx");
        }

        protected void check_Click(object sender, EventArgs e)
        {
            Response.Redirect("tuktukancheckup.aspx");
        }

        protected void pre_Click(object sender, EventArgs e)
        {
            Response.Redirect("tuktukanprenatal.aspx");
        }
    }
}