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
    public partial class category : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-3AMSICV;Initial Catalog=center;Integrated Security=True");


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                illness();
                others();

            }
        }

        //For Data table
        void illness()
        {
            SqlCommand comm = new SqlCommand("select * from TableILLNESS where NO != 11 ORDER BY Illness ASC", con);
            SqlDataAdapter d = new SqlDataAdapter(comm);
            DataTable dt = new DataTable();
            d.Fill(dt);
            GridView3.DataSource = dt;
            GridView3.DataBind();

           


            /* for (int i = 0; i< GridView3.Rows.Count -1; i++)
            {
                if (GridView3.Rows[i].Cells[3].Text == i)
                {
                    GridView3.Rows[i].Visible = false;
                }
            } */


        }

        void others()
        {
            SqlCommand commm = new SqlCommand("select Others from TableCHECKUP ORDER BY Others DESC", con);
            SqlDataAdapter dd = new SqlDataAdapter(commm);
            DataTable dtt = new DataTable();
            dd.Fill(dtt);
            GridView4.DataSource = dtt;
            GridView4.DataBind();

        }


        protected void dashboard_Click(object sender, EventArgs e)
        {
            Response.Redirect("cityhalladmin.aspx");
        }

        protected void checkup_Click(object sender, EventArgs e)
        {
            Response.Redirect("checkup.aspx");
        }

        protected void prenatal_Click(object sender, EventArgs e)
        {
            Response.Redirect("prenatal.aspx");
        }

        protected void catgry_Click(object sender, EventArgs e)
        {
            Response.Redirect("category.aspx");
        }

        protected void staff_Click(object sender, EventArgs e)
        {
            Response.Redirect("staff.aspx");
        }

        protected void Account_Click(object sender, EventArgs e)
        {

            Response.Redirect("account.aspx");
        }

        protected void logout_Click(object sender, EventArgs e)
        {
            //logout na bobo 
            Response.Write("<script>alert('Logout Admin');window.location = 'login.aspx';</script>"); //works great    

        }

        protected void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            //checbox
            bool iselect = ((CheckBox)GridView3.HeaderRow.FindControl("CheckBox2")).Checked;
            for (int i = 0; i < GridView3.Rows.Count; i++)
            {
                if (iselect == true)
                {
                    ((CheckBox)GridView3.Rows[i].FindControl("CheckBox1")).Checked = true;
                }
                else if (iselect == false)
                {
                    ((CheckBox)GridView3.Rows[i].FindControl("CheckBox1")).Checked = false;
                }
            }
        }

        protected void Button15_Click(object sender, EventArgs e)
        {
            ////select
            int rowind = ((GridViewRow)(sender as Control).NamingContainer).RowIndex;

            txtid.Text = GridView3.Rows[rowind].Cells[2].Text;
            txtill.Text = GridView3.Rows[rowind].Cells[3].Text;
        }

        protected void add_Click(object sender, EventArgs e)
        {
            //add
            con.Open();
            SqlCommand comm = new SqlCommand("Insert into TableILLNESS values('" + txtill.Text + "')", con);
            comm.ExecuteNonQuery();
            con.Close();

            txtid.Text = "";
            txtill.Text = "";
            
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Added Successfully');", true);
            illness();

        }

        protected void update_Click(object sender, EventArgs e)
        {
            //update
            con.Open();
            SqlCommand comm = new SqlCommand("update TableILLNESS set Illness = '" + txtill.Text + "' where NO = '" + int.Parse(txtid.Text) + "'", con);
            comm.ExecuteNonQuery();
            con.Close();

            txtid.Text = "";
            txtill.Text = "";

            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Successfully Updated');", true);
            illness();
        }

        protected void delete_Click(object sender, EventArgs e)
        {
            //delete button experimental
            int id = 0;
            for (int i = 0; i < GridView3.Rows.Count; i++)
            {
                CheckBox CheckBox1 = (CheckBox)GridView3.Rows[i].FindControl("CheckBox1");
                if (CheckBox1.Checked == true)
                {
                    id = Convert.ToInt32(GridView3.Rows[i].Cells[2].Text);
                    con.Open();
                    SqlCommand comm = new SqlCommand("delete TableILLNESS where NO='" + id + "' ", con);
                    comm.ExecuteNonQuery();
                    con.Close();


                }
            }
            Response.Write("<script>alert(' Delete Successful ')</script>");
            illness();
        }

        protected void clear_Click(object sender, EventArgs e)
        {
            txtid.Text = "";
            txtill.Text = "";
        }
    }
}