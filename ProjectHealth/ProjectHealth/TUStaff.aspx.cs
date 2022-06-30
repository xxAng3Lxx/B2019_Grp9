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
    public partial class TUStaff : System.Web.UI.Page
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
            SqlCommand comm = new SqlCommand("select * from TableSTAFF WHERE Brgy='Tuktukan' ORDER BY Name ASC ", con);
            SqlDataAdapter d = new SqlDataAdapter(comm);
            DataTable dt = new DataTable();
            d.Fill(dt);
            GridView5.DataSource = dt;
            GridView5.DataBind();
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

        protected void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            //checkbox
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
            //selcts
            //selectss
            int rowind = ((GridViewRow)(sender as Control).NamingContainer).RowIndex;

            txtid.Text = GridView5.Rows[rowind].Cells[2].Text;
            txtname.Text = GridView5.Rows[rowind].Cells[3].Text;
            txtposition.Text = GridView5.Rows[rowind].Cells[4].Text;
            txtbrgy.Text = GridView5.Rows[rowind].Cells[5].Text;
        }

        protected void Button12_Click(object sender, EventArgs e)
        {
            //update
            //update
            con.Open();
            SqlCommand comm = new SqlCommand("update TableSTAFF set Name = '" + txtname.Text + "',Position = '" + txtposition.Text + "',Brgy = '" + txtbrgy.Text + "'  where No = '" + int.Parse(txtid.Text) + "'", con);
            comm.ExecuteNonQuery();
            con.Close();

            txtid.Text = "";
            txtname.Text = "";
            txtposition.Text = "";
            txtbrgy.Text = "";

            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Successfully Updated');", true);
            LoadRecord();
        }

        protected void Button13_Click(object sender, EventArgs e)
        {
            //deleet
            //delete
            string confirmValue = Request.Form["confirm_value"];

            if (confirmValue == "Yes")
            {

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
            else
            {
                //delete
                bool iselect = ((CheckBox)GridView5.HeaderRow.FindControl("CheckBox2")).Checked;
                for (int i = 0; i < GridView5.Rows.Count; i++)
                {
                    if (iselect == false || iselect == true)
                    {
                        ((CheckBox)GridView5.Rows[i].FindControl("CheckBox1")).Checked = false;
                        ((CheckBox)GridView5.HeaderRow.FindControl("CheckBox2")).Checked = false;
                    }
                }
            }

        }

        protected void Button14_Click(object sender, EventArgs e)
        {
            //clear
            //clear
            txtid.Text = "";
            txtname.Text = "";
            txtposition.Text = "";
            txtbrgy.Text = "";
        }
    }
}