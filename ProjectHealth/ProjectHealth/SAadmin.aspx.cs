using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Web.UI.DataVisualization.Charting;
using System.Drawing;

namespace ProjectHealth
{
    public partial class SAadmin : System.Web.UI.Page
    {

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-3AMSICV;Initial Catalog=center;Integrated Security=True");


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //checkuppppppp
                con.Open();

                SqlCommand cmd = new SqlCommand("Select Count(*) From TableCHECKUP WHERE Brgy='Staana'", con);
                var count = cmd.ExecuteScalar();
                lblcheckup.Text = count.ToString();

                SqlCommand cmd4 = new SqlCommand("Select Count(*) From TableCHECKUP WHERE (Brgy='Staana' AND Gender='Male')", con);
                var count4 = cmd4.ExecuteScalar();
                lblmale.Text = count4.ToString();

                SqlCommand cmd6 = new SqlCommand("Select Count(*) From TableCHECKUP WHERE (Brgy='Staana' AND Gender='Female')", con);
                var count6 = cmd6.ExecuteScalar();
                lblfemale.Text = count6.ToString();

                SqlCommand cmd2 = new SqlCommand("Select Count(*) From TablePRENATAL WHERE Brgy='Staana'", con);
                var count2 = cmd2.ExecuteScalar();
                lblprenatal.Text = count2.ToString();

                
                SqlCommand cmd3 = new SqlCommand("Select Count(*) From TableSTAFF WHERE Brgy='Staana'", con);
                var count3 = cmd3.ExecuteScalar();
                lblstaff.Text = count3.ToString();

                con.Close();

                //------GRAPH-----------------------


              


              //  Chart1.ChartAreas[0].AxisX.Name("hakhk");

                //Chart1.ChartAreas[0].AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 12);
                //Chart1.Palette = ChartColorPalette.Berry;
                //   Chart1.Legends[0].Enabled = true;







            }
        }

        protected void Dashboard_Click(object sender, EventArgs e)
        {
            Response.Redirect("SAadmin.aspx");
        }

        protected void Checkup_Click(object sender, EventArgs e)
        {
            Response.Redirect("SACheckup.aspx");
        }

        protected void Prenatal_Click(object sender, EventArgs e)
        {
            Response.Redirect("SAPrenatal.aspx");
        }


        protected void Staff_Click(object sender, EventArgs e)
        {
            Response.Redirect("SAStaff.aspx");
        }

        protected void Account_Click(object sender, EventArgs e)
        {
            Response.Redirect("SAAccount.aspx");
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            //lougot
            //logout
            Response.Write("<script>alert('Logout Admin');window.location = 'login.aspx';</script>"); //works great    

        }

        //---------------------------
        private static DataTable GetData(string query)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(query);
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-3AMSICV;Initial Catalog=center;Integrated Security=True");

            SqlDataAdapter sda = new SqlDataAdapter();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            sda.SelectCommand = cmd;
            sda.Fill(dt);
            return dt;
        }
    }
}