using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace ProjectHealth
{
    public partial class staanacheckup : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-3AMSICV;Initial Catalog=center;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {
           

            if (!IsPostBack)
            {
                drop();

            }
        }


        //dropdown
        void drop()
        {
            con.Open();

            string com = "Select Illness from TableILLNESS ORDER BY Illness ASC";
            SqlDataAdapter adpt = new SqlDataAdapter(com, con);
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            txtillness.DataSource = dt;
            txtillness.DataBind();
            txtillness.DataTextField = "Illness";
            txtillness.DataBind();


            con.Close();

        }



        protected void Button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand comm = new SqlCommand("Insert into TableCHECKUP values('" + txtpatient.Text + "','" + txtaddress.Text + "','" + txtdate.Text + "','" + txtcontact.Text + "','" + txtgender.SelectedValue + "','" + int.Parse(txtage.Text) + "','" + txtillness.SelectedValue + "','" + txtothers.Text + "','" + txtbrgy.Text + "')", con);
            comm.ExecuteNonQuery();
            con.Close();
            txtpatient.Text = "";
            txtaddress.Text = "";
            txtdate.Text = "";
            txtcontact.Text = "";
            txtage.Text = "";
            txtillness.SelectedValue = null;
            txtgender.Text = "";
            txtothers.Text = "";
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Reservation Successfully');", true);
        }

        protected void homepage_Click(object sender, EventArgs e)
        {
            Response.Redirect("homepage.aspx");
        }

        protected void staana_Click(object sender, EventArgs e)
        {
            Response.Redirect("staana.aspx");
        }

        protected void checkup_Click(object sender, EventArgs e)
        {
            Response.Redirect("staanacheckup.aspx");
        }

        protected void prenatal_Click(object sender, EventArgs e)
        {
            Response.Redirect("staanaprenatal.aspx");
        }
    }
}