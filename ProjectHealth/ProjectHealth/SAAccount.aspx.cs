using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace ProjectHealth
{
    public partial class SAAccount : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-3AMSICV;Initial Catalog=center;Integrated Security=True");


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                ac();

            }
        }

        //For Data table
        void ac()
        {
            SqlCommand comm = new SqlCommand("select * from TableLOGIN WHERE username='Staana'", con);
            SqlDataAdapter d = new SqlDataAdapter(comm);
            DataTable dt = new DataTable();
            d.Fill(dt);
            GridView7.DataSource = dt;
            GridView7.DataBind();

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
            //logout
            Response.Write("<script>alert('Logout Admin');window.location = 'login.aspx';</script>"); //works great    

        }

        protected void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            //checkbox
        }

        protected void Button15_Click(object sender, EventArgs e)
        {
            //selects
            //select idol
            int rowind = ((GridViewRow)(sender as Control).NamingContainer).RowIndex;

            txtid.Text = GridView7.Rows[rowind].Cells[1].Text;
            txtusernames.Text = GridView7.Rows[rowind].Cells[2].Text;
            txtpasswords.Text = GridView7.Rows[rowind].Cells[3].Text;
            txtbrgy.Text = GridView7.Rows[rowind].Cells[4].Text;
        }

        protected void update_Click(object sender, EventArgs e)
        {
            //update
            con.Open();
            SqlCommand comm = new SqlCommand("update TableLOGIN set username = '" + txtusernames.Text + "',password = '" + txtpasswords.Text + "',usertype = '" + txtbrgy.Text + "'  where id = '" + int.Parse(txtid.Text) + "'", con);
            comm.ExecuteNonQuery();
            con.Close();

            txtid.Text = "";
            txtusernames.Text = "";
            txtpasswords.Text = "";
            txtbrgy.Text = "";

            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Successfully Updated');", true);
            ac();
        }

        protected void clear_Click(object sender, EventArgs e)
        {
            txtid.Text = "";
            txtusernames.Text = "";
            txtpasswords.Text = "";
            txtbrgy.Text = "";
        }
    }
}