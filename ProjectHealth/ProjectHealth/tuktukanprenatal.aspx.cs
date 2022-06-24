using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace ProjectHealth
{
    public partial class tuktukanprenatal : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-3AMSICV;Initial Catalog=center;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void homepage_Click(object sender, EventArgs e)
        {
            Response.Redirect("homepage.aspx");
        }

        protected void tuktukan_Click(object sender, EventArgs e)
        {
            Response.Redirect("tuktukan.aspx");
        }

        protected void tuktukancheck_Click(object sender, EventArgs e)
        {
            Response.Redirect("tuktukancheckup.aspx");
        }

        protected void tuktukanpre_Click(object sender, EventArgs e)
        {
            Response.Redirect("tuktukanprenatal.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand comm = new SqlCommand("Insert into TablePRENATAL values('" + txtpname.Text + "','" + int.Parse(txtpage.Text) + "','" + txtpaddress.Text + "','" + txtpdate.Text + "','" + txtpcontact.Text + "','" + txtbrgy.Text + "')", con);
            comm.ExecuteNonQuery();
            con.Close();

            txtpname.Text = "";
            txtpage.Text = "";
            txtpaddress.Text = "";
            txtpdate.Text = "";
            txtpcontact.Text = "";

            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Reservation Successfully');", true);

        }
    }
}