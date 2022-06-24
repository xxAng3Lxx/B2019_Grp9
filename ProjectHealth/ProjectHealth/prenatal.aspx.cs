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
    public partial class prenatal : System.Web.UI.Page
    {

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-3AMSICV;Initial Catalog=center;Integrated Security=True");



        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                prenataltable();

            }
        }

        //For Data table
        void prenataltable()
        {
            SqlCommand comm = new SqlCommand("select * from TablePRENATAL ORDER BY Date ASC ", con);
            SqlDataAdapter d = new SqlDataAdapter(comm);
            DataTable dt = new DataTable();
            d.Fill(dt);
            GridView2.DataSource = dt;
            GridView2.DataBind();
        }




        protected void Button1_Click(object sender, EventArgs e)
        {
            //Dashboard
            Response.Redirect("cityhalladmin.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //ID="Checkup"
            Response.Redirect("checkup.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            //ID="Prenatal" 
            Response.Redirect("prenatal.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            //ID="Category"
            Response.Redirect("category.aspx");
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            // ID = "Staff"
            Response.Redirect("staff.aspx");
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            //ID="Account" 

            Response.Redirect("account.aspx");
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            //ID="Out" 
            //logout na bobo 
            Response.Write("<script>alert('Logout Admin');window.location = 'login.aspx';</script>"); //works great    

        }

        protected void search_Click(object sender, EventArgs e)
        {
            //search
            prenataltable();
        }

        protected void ddsearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            //dropdownsearch 

            SqlCommand comm = new SqlCommand("select * from TablePRENATAL where Brgy='" + ddsearch.SelectedItem.Text + "' ORDER BY Date ASC ", con);
            con.Open();

            SqlDataAdapter d = new SqlDataAdapter(comm);
            DataTable dt = new DataTable();
            d.Fill(dt);
            GridView2.DataSource = dt;
            GridView2.DataBind();
            con.Close();
        }

        protected void Add_Click(object sender, EventArgs e)
        {
            //add
         //   con.Open();
           // SqlCommand comm = new SqlCommand("Insert into TablePRENATAL values('" + txtmname.Text + "','" + txtage.Text + "','" + txtaddress.Text + "','" + txtdate.Text + "','" + txtcontact.Text + "','" +txtbrgy.SelectedValue + "')", con);
            //comm.ExecuteNonQuery();
            //con.Close();

            //txtid.Text = "";
            //txtmname.Text = "";
            //txtage.Text = "";
            //txtaddress.Text = "";
            //txtdate.Text = "";
            //txtcontact.Text = "";
            //txtbrgy.SelectedValue = null;

            //ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Added Successfully');", true);
            //prenataltable();
        }

        protected void delete_Click(object sender, EventArgs e)
        {
             

            string confirmValue = Request.Form["confirm_value"];

            if (confirmValue == "Yes")
            {
                //delete
                //delete button experimental
                int id = 0;
                for (int i = 0; i < GridView2.Rows.Count; i++)
                {
                    CheckBox CheckBox1 = (CheckBox)GridView2.Rows[i].FindControl("CheckBox1");
                    if (CheckBox1.Checked == true)
                    {
                        id = Convert.ToInt32(GridView2.Rows[i].Cells[2].Text);
                        con.Open();
                        SqlCommand comm = new SqlCommand("delete TablePRENATAL where No='" + id + "' ", con);
                        comm.ExecuteNonQuery();
                        con.Close();


                    }
                }
                Response.Write("<script>alert(' Delete Successful ')</script>");
                prenataltable();
            }
            else
            {
                //delete
                bool iselect = ((CheckBox)GridView2.HeaderRow.FindControl("CheckBox2")).Checked;
                for (int i = 0; i < GridView2.Rows.Count; i++)
                {
                    if (iselect == false || iselect == true)
                    {
                        ((CheckBox)GridView2.Rows[i].FindControl("CheckBox1")).Checked = false;
                        ((CheckBox)GridView2.HeaderRow.FindControl("CheckBox2")).Checked = false;
                    }
                }
            }


        }

        protected void update_Click(object sender, EventArgs e)
        {
            //update
            con.Open();
            SqlCommand comm = new SqlCommand("update TablePRENATAL set Mothername = '" + txtmname.Text + "', Age = '" + txtage.Text + "', Address = '" + txtaddress.Text + "', Date = '" + txtdate.Text + "', Contact = '" + txtcontact.Text + "', Brgy = '" + txtbrgy.SelectedValue + "' where No = '" + int.Parse(txtid.Text) + "'", con);
            comm.ExecuteNonQuery();
            con.Close();

            txtid.Text = "";
            txtmname.Text = "";
            txtage.Text = "";
            txtaddress.Text = "";
            txtdate.Text = "";
            txtcontact.Text = "";
            txtbrgy.SelectedValue = null;

            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Successfully Updated');", true);
            prenataltable();
        }

        protected void clear_Click(object sender, EventArgs e)
        {

            txtid.Text = "";
            txtmname.Text = "";
            txtage.Text = "";
            txtaddress.Text = "";
            txtdate.Text = "";
            txtcontact.Text = "";
            txtbrgy.SelectedValue = null;
        }

        protected void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            //checbox
            bool iselect = ((CheckBox)GridView2.HeaderRow.FindControl("CheckBox2")).Checked;
            for (int i = 0; i < GridView2.Rows.Count; i++)
            {
                if (iselect == true)
                {
                    ((CheckBox)GridView2.Rows[i].FindControl("CheckBox1")).Checked = true;
                }
                else if (iselect == false)
                {
                    ((CheckBox)GridView2.Rows[i].FindControl("CheckBox1")).Checked = false;
                }
            }


        }

        protected void Button15_Click(object sender, EventArgs e)
        {
            //select
            ////select
            ////select
            int rowind = ((GridViewRow)(sender as Control).NamingContainer).RowIndex;


            txtid.Text = GridView2.Rows[rowind].Cells[2].Text;
            txtmname.Text = GridView2.Rows[rowind].Cells[3].Text;
            txtage.Text = GridView2.Rows[rowind].Cells[4].Text;
            txtaddress.Text = GridView2.Rows[rowind].Cells[5].Text;
            txtdate.Text = GridView2.Rows[rowind].Cells[6].Text;
            txtcontact.Text = GridView2.Rows[rowind].Cells[7].Text;
            txtbrgy.SelectedValue = GridView2.Rows[rowind].Cells[8].Text;
           
        }
    }
}