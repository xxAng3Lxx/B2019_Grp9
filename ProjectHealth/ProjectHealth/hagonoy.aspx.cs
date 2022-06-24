using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace ProjectHealth
{
    public partial class hagonoy : System.Web.UI.Page
    {

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-3AMSICV;Initial Catalog=center;Integrated Security=True");


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadRecord();
                experiment();
            }
        }

        //For Data GridView Below
        void LoadRecord()
        {
            SqlCommand comm = new SqlCommand("select * from checkuptable  WHERE illness='UTI' ORDER BY date ASC ", con);
            SqlDataAdapter d = new SqlDataAdapter(comm);
            DataTable dt = new DataTable();
            d.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
        void experiment()
        {
            SqlCommand comm = new SqlCommand("Select Count(*) As countrows, Illness from TableCHECKUP Group by Illness Having(Count(*) > -1)order by countrows asc", con);
            SqlDataAdapter dd = new SqlDataAdapter(comm);
            DataTable dtt = new DataTable();
            dd.Fill(dtt);
            GridView2.DataSource = dtt;
            GridView2.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //delete button experimental
            int id = 0;
            for(int i=0; i<GridView2.Rows.Count; i++)
            {
                CheckBox CheckBox1 = (CheckBox)GridView2.Rows[i].FindControl("CheckBox1");
                if(CheckBox1.Checked == true)
                {
                    id = Convert.ToInt32(GridView2.Rows[i].Cells[1].Text);
                    con.Open();
                    SqlCommand comm = new SqlCommand("delete checkuptable where no='"+ id +"' ", con);
                    comm.ExecuteNonQuery();
                    con.Close();


                }
            }
             Response.Write("<script>alert(' Delete Successful ')</script>");

            experiment();
            LoadRecord();
        }

        protected void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void CheckBox2_CheckedChanged1(object sender, EventArgs e)
        {
            bool iselect = ((CheckBox)GridView2.HeaderRow.FindControl("CheckBox2")).Checked;
            for (int i=0; i<GridView2.Rows.Count; i++)
            {
                if (iselect == true)
                {
                    ((CheckBox)GridView2.Rows[i].FindControl("CheckBox1")).Checked = true;
                }else if (iselect == false)
                {
                    ((CheckBox)GridView2.Rows[i].FindControl("CheckBox1")).Checked = false;
                }
            }

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand comm = new SqlCommand("select * from TableCHECKUP where Brgy='"+ DropDownList1.SelectedItem.Text+ "' ", con);
            con.Open();

            SqlDataAdapter dd = new SqlDataAdapter(comm);
            DataTable dtt = new DataTable();
            dd.Fill(dtt);
            GridView2.DataSource = dtt;
            GridView2.DataBind();
            con.Close();

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            experiment();
        }
    }
}