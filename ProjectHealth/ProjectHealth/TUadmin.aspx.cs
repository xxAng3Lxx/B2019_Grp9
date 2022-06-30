using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.DataVisualization.Charting;
using System.Drawing;
using System.Data.SqlClient;
using System.Data;

namespace ProjectHealth
{
    public partial class TUadmin : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-3AMSICV;Initial Catalog=center;Integrated Security=True");


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //checkuppppppp
                con.Open();

                SqlCommand cmd = new SqlCommand("Select Count(*) From TableCHECKUP WHERE Brgy='Tuktukan'", con);
                var count = cmd.ExecuteScalar();
                lblcheckup.Text = count.ToString();

                SqlCommand cmd4 = new SqlCommand("Select Count(*) From TableCHECKUP WHERE (Brgy='Tuktukan' AND Gender='Male')", con);
                var count4 = cmd4.ExecuteScalar();
                lblmale.Text = count4.ToString();

                SqlCommand cmd6 = new SqlCommand("Select Count(*) From TableCHECKUP WHERE (Brgy='Tuktukan' AND Gender='Female')", con);
                var count6 = cmd6.ExecuteScalar();
                lblfemale.Text = count6.ToString();

                SqlCommand cmd2 = new SqlCommand("Select Count(*) From TablePRENATAL WHERE Brgy='Tuktukan'", con);
                var count2 = cmd2.ExecuteScalar();
                lblprenatal.Text = count2.ToString();


                SqlCommand cmd3 = new SqlCommand("Select Count(*) From TableSTAFF WHERE Brgy='Tuktukan'", con);
                var count3 = cmd3.ExecuteScalar();
                lblstaff.Text = count3.ToString();

                con.Close();

               
            }
        }

        protected void Dashboard_Click(object sender, EventArgs e)
        {
            Response.Redirect("TUadmin.aspx");
        }

        protected void Checkup_Click(object sender, EventArgs e)
        {
            Response.Redirect("TUCheckup.aspx");
        }

        protected void Prenatal_Click(object sender, EventArgs e)
        {
            Response.Redirect("TUPrenatal.aspx");
        }

        protected void Staff_Click(object sender, EventArgs e)
        {
            Response.Redirect("TUStaff.aspx");
        }

        protected void Account_Click(object sender, EventArgs e)
        {
            Response.Redirect("TUAccount.aspx");
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            //logout
            Response.Write("<script>alert('Logout Admin');window.location = 'login.aspx';</script>"); //works great    

        }
    }
}