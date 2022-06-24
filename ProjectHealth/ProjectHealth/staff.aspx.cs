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
    public partial class staff : System.Web.UI.Page
    {

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-3AMSICV;Initial Catalog=center;Integrated Security=True");


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadRecord();

            }
        }

        void LoadRecord()
        {
            SqlCommand comm = new SqlCommand("select * from TableSTAFF ORDER BY Name ASC ", con);
            SqlDataAdapter d = new SqlDataAdapter(comm);
            DataTable dt = new DataTable();
            d.Fill(dt);
            GridView5.DataSource = dt;
            GridView5.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //dashhboard
            Response.Redirect("cityhalladmin.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //checkup
            Response.Redirect("checkup.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            //pre
            Response.Redirect("prenatal.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            //cat
            Response.Redirect("category.aspx");
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            //staf
            Response.Redirect("staff.aspx");
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            //acc
            Response.Redirect("account.aspx");
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            //log//logout na bobo 
            Response.Write("<script>alert('Logout Admin');window.location = 'login.aspx';</script>"); //works great    

        }

        protected void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            //checlbox
            //checbox
            bool iselect = ((CheckBox)GridView5.HeaderRow.FindControl("CheckBox2")).Checked;
            for (int i = 0; i < GridView5.Rows.Count; i++)
            {
                if (iselect == true)
                {
                    ((CheckBox)GridView5.Rows[i].FindControl("CheckBox1")).Checked = true;
                }
                else if (iselect == false)
                {
                    ((CheckBox)GridView5.Rows[i].FindControl("CheckBox1")).Checked = false;
                }
            }
        }

        protected void Button15_Click(object sender, EventArgs e)
        {
            //select
            int rowind = ((GridViewRow)(sender as Control).NamingContainer).RowIndex;

            txtid.Text = GridView5.Rows[rowind].Cells[2].Text;
            txtname.Text = GridView5.Rows[rowind].Cells[3].Text;
            txtposition.Text = GridView5.Rows[rowind].Cells[4].Text;
            txtbrgy.Text = GridView5.Rows[rowind].Cells[5].Text;

        }

        protected void search_Click(object sender, EventArgs e)
        {
            LoadRecord();
        }

        protected void ddsearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand comm = new SqlCommand("select * from TableSTAFF where Brgy='" + ddsearch.SelectedItem.Text + "' ORDER BY Name ASC ", con);
            con.Open();

            SqlDataAdapter d = new SqlDataAdapter(comm);
            DataTable dt = new DataTable();
            d.Fill(dt);
            GridView5.DataSource = dt;
            GridView5.DataBind();
            con.Close();
        }

        protected void add_Click(object sender, EventArgs e)
        {
            //add
            con.Open();
            SqlCommand comm = new SqlCommand("Insert into TableSTAFF values('" + txtname.Text + "','" + txtposition.Text + "' ,'" + txtbrgy.SelectedValue + "')", con);
            comm.ExecuteNonQuery();
            con.Close();
            
            txtid.Text = "";
            txtname.Text = "";
            txtposition.Text = "";  
            txtbrgy.SelectedValue = null;

            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Added Successfully');", true);
            LoadRecord();
        }

        protected void update_Click(object sender, EventArgs e)
        {
            //update
            con.Open();
            SqlCommand comm = new SqlCommand("update TableSTAFF set Name = '" + txtname.Text + "',Position = '" + txtposition.Text + "',Brgy = '" + txtbrgy.SelectedValue + "'  where No = '" + int.Parse(txtid.Text) + "'", con);
            comm.ExecuteNonQuery();
            con.Close();

            txtid.Text = "";
            txtname.Text = "";
            txtposition.Text = "";
            txtbrgy.SelectedValue = null;

            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Successfully Updated');", true);
            LoadRecord();
        }

        protected void delete_Click(object sender, EventArgs e)
        {
            //delete button experimental
            int id = 0;
            for (int i = 0; i < GridView5.Rows.Count; i++)
            {
                CheckBox CheckBox1 = (CheckBox)GridView5.Rows[i].FindControl("CheckBox1");
                if (CheckBox1.Checked == true)
                {
                    id = Convert.ToInt32(GridView5.Rows[i].Cells[2].Text);
                    con.Open();
                    SqlCommand comm = new SqlCommand("delete TableSTAFF where No='" + id + "' ", con);
                    comm.ExecuteNonQuery();
                    con.Close();


                }
            }
            Response.Write("<script>alert(' Delete Successful ')</script>");
            LoadRecord();
        }

        protected void clear_Click(object sender, EventArgs e)
        {
            txtid.Text = "";
            txtname.Text = "";
            txtposition.Text = "";
            txtbrgy.SelectedValue = null;
        }
    }
}