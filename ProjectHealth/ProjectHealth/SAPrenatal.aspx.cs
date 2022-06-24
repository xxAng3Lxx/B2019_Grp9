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
    public partial class SAPrenatal : System.Web.UI.Page
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
            SqlCommand comm = new SqlCommand("select * from TablePRENATAL WHERE Brgy='Staana' ORDER BY Date ASC ", con);
            SqlDataAdapter d = new SqlDataAdapter(comm);
            DataTable dt = new DataTable();
            d.Fill(dt);
            GridView2.DataSource = dt;
            GridView2.DataBind();
        }

        protected void Dashboard_Click(object sender, EventArgs e)
        {
            //dashboard
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
            //delete
            //delete
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
            //selects
            ////select
            int rowind = ((GridViewRow)(sender as Control).NamingContainer).RowIndex;


            txtid.Text = GridView2.Rows[rowind].Cells[2].Text;
            txtmname.Text = GridView2.Rows[rowind].Cells[3].Text;
            txtage.Text = GridView2.Rows[rowind].Cells[4].Text;
            txtaddress.Text = GridView2.Rows[rowind].Cells[5].Text;
            txtdate.Text = GridView2.Rows[rowind].Cells[6].Text;
            txtcontact.Text = GridView2.Rows[rowind].Cells[7].Text;
            txtbrgy.Text = GridView2.Rows[rowind].Cells[8].Text;
        }

        protected void delete_Click(object sender, EventArgs e)
        {
            
            string confirmValue = Request.Form["confirm_value"];

            if (confirmValue == "Yes")
            {
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
            SqlCommand comm = new SqlCommand("update TablePRENATAL set Mothername = '" + txtmname.Text + "', Age = '" + txtage.Text + "', Address = '" + txtaddress.Text + "', Date = '" + txtdate.Text + "', Contact = '" + txtcontact.Text + "', Brgy = '" + txtbrgy.Text + "' where No = '" + int.Parse(txtid.Text) + "'", con);
            comm.ExecuteNonQuery();
            con.Close();

            txtid.Text = "";
            txtmname.Text = "";
            txtage.Text = "";
            txtaddress.Text = "";
            txtdate.Text = "";
            txtcontact.Text = "";
            txtbrgy.Text = "";

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
            txtbrgy.Text = "";
        }
    }
}