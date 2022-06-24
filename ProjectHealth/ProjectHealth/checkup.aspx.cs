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
    public partial class checkup : System.Web.UI.Page
    {

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-3AMSICV;Initial Catalog=center;Integrated Security=True");

        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadRecord();
                drop();


            }
        

        }
        //For Data table
        void LoadRecord()
        {
            SqlCommand comm = new SqlCommand("select * from TableCHECKUP ORDER BY date ASC ", con);
            SqlDataAdapter d = new SqlDataAdapter(comm);
            DataTable dt = new DataTable();
            d.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
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


        protected void Dashboard_Click(object sender, EventArgs e)
        {
            Response.Redirect("cityhalladmin.aspx");

        }

        protected void Checkup_Click(object sender, EventArgs e)
        {
            Response.Redirect("checkup.aspx");
        }

        protected void Prenatal_Click(object sender, EventArgs e)
        {
            Response.Redirect("prenatal.aspx");
        }

        protected void Category_Click(object sender, EventArgs e)
        {
            Response.Redirect("category.aspx");
        }

        protected void Staff_Click(object sender, EventArgs e)
        {
            Response.Redirect("staff.aspx");
        }

        protected void Account_Click(object sender, EventArgs e)
        {

            Response.Redirect("account.aspx");
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            //logout na bobo 
            Response.Write("<script>alert('Logout Admin');window.location = 'login.aspx';</script>"); //works great    

        }

        protected void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            bool iselect = ((CheckBox)GridView1.HeaderRow.FindControl("CheckBox2")).Checked;
            for (int i = 0; i < GridView1.Rows.Count; i++)
            {
                if (iselect == true)
                {
                    ((CheckBox)GridView1.Rows[i].FindControl("CheckBox1")).Checked = true;
                }
                else if (iselect == false)
                {
                    ((CheckBox)GridView1.Rows[i].FindControl("CheckBox1")).Checked = false;
                }
            }
        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            LoadRecord();
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand comm = new SqlCommand("select * from TableCHECKUP where Brgy='" + DropDownList1.SelectedItem.Text + "' ORDER BY Date ASC ", con);
            con.Open();

            SqlDataAdapter d = new SqlDataAdapter(comm);
            DataTable dt = new DataTable();
            d.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
            con.Close();
        }

        protected void Button11_Click(object sender, EventArgs e)
        {
            //add

           // con.Open();
            //SqlCommand comm = new SqlCommand("Insert into TableCHECKUP values('" + txtpatient.Text + "','" + txtaddress.Text + "','" + txtdate.Text + "','" + txtcontact.Text + "','" + txtgender.SelectedValue + "','" + int.Parse(txtage.Text) + "','" + txtillness.SelectedValue + "','" + txtothers.Text + "','" + txtbgry.SelectedValue + "')", con);
            //comm.ExecuteNonQuery();
            //con.Close();
            //txtid.Text = "";
            //txtpatient.Text = "";
           // txtaddress.Text = "";
           // txtdate.Text = "";
           // txtcontact.Text = "";
           // txtage.Text = "";
            //txtillness.SelectedValue = null;
            //txtgender.SelectedValue = null;
            //txtothers.Text = "";
            //txtbgry.SelectedValue = null;
            //ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Added Successfully');", true);
            //LoadRecord();
        }

        protected void Button12_Click(object sender, EventArgs e)
        {
            //update
            con.Open();
            SqlCommand comm = new SqlCommand("update TableCHECKUP set Fullname = '" + txtpatient.Text + "', Address = '" + txtaddress.Text + "', Date = '" + txtdate.Text + "', Contact = '" + txtcontact.Text + "', Gender = '" + txtgender.SelectedValue + "', Age = '" + int.Parse(txtage.Text) + "', Illness = '" + txtillness.SelectedValue + "', Others = '" + txtothers.Text + "', Brgy = '" + txtbgry.SelectedValue + "' where Number = '" + int.Parse(txtid.Text) + "'", con);
            comm.ExecuteNonQuery();
            con.Close();
            txtid.Text = "";
            txtpatient.Text = "";
            txtaddress.Text = "";
            txtdate.Text = "";
            txtcontact.Text = "";
            txtage.Text = "";
            txtillness.SelectedValue = null;
            txtgender.SelectedValue = null;
            txtothers.Text = "";
            txtbgry.SelectedValue = null;
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Successfully Updated');", true);
            LoadRecord();
            drop();

        }

        protected void Button13_Click(object sender, EventArgs e)
        {
             

            string confirmValue = Request.Form["confirm_value"];

            if (confirmValue == "Yes")
            {
                //delete
                //delete button experimental
                int id = 0;
                for (int i = 0; i < GridView1.Rows.Count; i++)
                {
                    CheckBox CheckBox1 = (CheckBox)GridView1.Rows[i].FindControl("CheckBox1");
                    if (CheckBox1.Checked == true)
                    {
                        id = Convert.ToInt32(GridView1.Rows[i].Cells[2].Text);
                        con.Open();
                        SqlCommand comm = new SqlCommand("delete TableCHECKUP where Number='" + id + "' ", con);
                        comm.ExecuteNonQuery();
                        con.Close();


                    }
                }
                Response.Write("<script>alert(' Delete Successful ')</script>");
                LoadRecord();
            }
            else
            {
                //delete
                bool iselect = ((CheckBox)GridView1.HeaderRow.FindControl("CheckBox2")).Checked;
                for (int i = 0; i < GridView1.Rows.Count; i++)
                {
                    if (iselect == false || iselect == true)
                    {
                        ((CheckBox)GridView1.Rows[i].FindControl("CheckBox1")).Checked = false;
                        ((CheckBox)GridView1.HeaderRow.FindControl("CheckBox2")).Checked = false;
                    }
                }
            }




        }

        protected void Button14_Click(object sender, EventArgs e)
        {
            //clear
            txtid.Text = "";
            txtpatient.Text = "";
            txtaddress.Text = "";
            txtdate.Text = "";
            txtcontact.Text = "";
            txtage.Text = "";
            txtillness.SelectedItem.Text = null;
            txtgender.SelectedValue = null;
            txtothers.Text = "";
            txtbgry.SelectedValue = null;
        }

        protected void Button15_Click(object sender, EventArgs e)
        {
            ////select
            int rowind = ((GridViewRow)(sender as Control).NamingContainer).RowIndex;


            txtid.Text = GridView1.Rows[rowind].Cells[2].Text;
            txtpatient.Text = GridView1.Rows[rowind].Cells[3].Text;
            txtaddress.Text = GridView1.Rows[rowind].Cells[4].Text;
            txtdate.Text = GridView1.Rows[rowind].Cells[5].Text;
            txtcontact.Text = GridView1.Rows[rowind].Cells[6].Text;
            txtgender.SelectedValue = GridView1.Rows[rowind].Cells[7].Text;
            txtage.Text = GridView1.Rows[rowind].Cells[8].Text;
            txtillness.SelectedItem.Text = GridView1.Rows[rowind].Cells[9].Text;
            txtothers.Text = GridView1.Rows[rowind].Cells[10].Text;
            txtbgry.SelectedValue = GridView1.Rows[rowind].Cells[11].Text;

           
        }
    }
}