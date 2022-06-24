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
    public partial class account : System.Web.UI.Page
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
            SqlCommand comm = new SqlCommand("select * from TableLOGIN ORDER BY username ASC", con);
            SqlDataAdapter d = new SqlDataAdapter(comm);
            DataTable dt = new DataTable();
            d.Fill(dt);
            GridView7.DataSource = dt;
            GridView7.DataBind();

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
            //checkbox lods
            //checbox
            bool iselect = ((CheckBox)GridView7.HeaderRow.FindControl("CheckBox2")).Checked;
            for (int i = 0; i < GridView7.Rows.Count; i++)
            {
                if (iselect == true)
                {
                    ((CheckBox)GridView7.Rows[i].FindControl("CheckBox1")).Checked = true;
                }
                else if (iselect == false)
                {
                    ((CheckBox)GridView7.Rows[i].FindControl("CheckBox1")).Checked = false;
                }
            }
        }

        protected void Button15_Click(object sender, EventArgs e)
        {
            //select idol
            int rowind = ((GridViewRow)(sender as Control).NamingContainer).RowIndex;

            txtid.Text = GridView7.Rows[rowind].Cells[2].Text;
            txtusernames.Text = GridView7.Rows[rowind].Cells[3].Text;
            txtpasswords.Text = GridView7.Rows[rowind].Cells[4].Text;
            txtbrgy.Text = GridView7.Rows[rowind].Cells[5].Text;
        }

        protected void add_Click(object sender, EventArgs e)
        {
            //add
            con.Open();
            SqlCommand comm = new SqlCommand("Insert into TableLOGIN values('" + txtusernames.Text + "','" + txtpasswords.Text + "' ,'" + txtbrgy.SelectedValue + "')", con);
            comm.ExecuteNonQuery();
            con.Close();

            txtid.Text = "";
            txtusernames.Text = "";
            txtpasswords.Text = "";
            txtbrgy.SelectedValue = null;

            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Added Successfully');", true);
            ac();
        }

        protected void update_Click(object sender, EventArgs e)
        {
            //update
            con.Open();
            SqlCommand comm = new SqlCommand("update TableLOGIN set username = '" + txtusernames.Text + "',password = '" + txtpasswords.Text + "',usertype = '" + txtbrgy.SelectedValue + "'  where id = '" + int.Parse(txtid.Text) + "'", con);
            comm.ExecuteNonQuery();
            con.Close();

            txtid.Text = "";
            txtusernames.Text = "";
            txtpasswords.Text = "";
            txtbrgy.SelectedValue = null;

            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Successfully Updated');", true);
            ac();
        }

        protected void delete_Click(object sender, EventArgs e)
        {
            //delete button experimental
            int id = 0;
            for (int i = 0; i < GridView7.Rows.Count; i++)
            {
                CheckBox CheckBox1 = (CheckBox)GridView7.Rows[i].FindControl("CheckBox1");
                if (CheckBox1.Checked == true)
                {
                    id = Convert.ToInt32(GridView7.Rows[i].Cells[2].Text);
                    con.Open();
                    SqlCommand comm = new SqlCommand("delete TableLOGIN where id='" + id + "' ", con);
                    comm.ExecuteNonQuery();
                    con.Close();


                }
            }
            Response.Write("<script>alert(' Delete Successful ')</script>");
            ac();
        }

        protected void clear_Click(object sender, EventArgs e)
        {
            txtid.Text = "";
            txtusernames.Text = "";
            txtpasswords.Text = "";
            txtbrgy.SelectedValue = null;
        }
    }
}