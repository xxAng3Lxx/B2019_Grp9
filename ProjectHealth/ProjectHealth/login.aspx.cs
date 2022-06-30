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
    public partial class login : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-3AMSICV;Initial Catalog=center;Integrated Security=True");
        string str, username, password ,usertype;
        SqlCommand com;
        SqlDataAdapter sqlda;
        DataTable dt;
        int RowCount;

        protected void back_Click(object sender, ImageClickEventArgs e)
        {
            Response.Write("<script>alert('Health Center Page');window.location = 'homepage.aspx';</script>"); //works great    

        }

        protected void Page_Load(object sender, EventArgs e)
        {
            

        }

       

        protected void btnlogin_Click(object sender, EventArgs e)
        {
            con.Open();
            str = "Select * from TableLOGIN";
            com = new SqlCommand(str);
            sqlda = new SqlDataAdapter(com.CommandText, con);
            dt = new DataTable();
            sqlda.Fill(dt);
            RowCount = dt.Rows.Count;
            string item = txtusertype.SelectedItem.ToString();
            for (int i = 0; i < RowCount; i++)
            {
                username = dt.Rows[i]["userName"].ToString();
                password = dt.Rows[i]["password"].ToString();
                if (username == txtuser.Text && password == txtpass.Text)
                {
                    //Session["UserName"] = UserName;
                    if (username == "Admin" && dt.Rows[i]["usertype"].ToString() == item)
                        Response.Write("<script>alert('Welcome to Health Center Admin');window.location = 'cityhalladmin.aspx';</script>"); //works great    
                    else if (username == "Tuktukan" && dt.Rows[i]["usertype"].ToString() == item)
                        Response.Write("<script>alert('Welcome to Barangay Tuktukan');window.location = 'TUadmin.aspx';</script>"); //works great    
                    else if (username == "Staana" && dt.Rows[i]["usertype"].ToString() == item)
                        Response.Write("<script>alert('Welcome to Barangay staana');window.location = 'SAadmin.aspx';</script>"); //works great    

                   
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Incorrect Username-Password-Usertype Combination');", true);

                  


                }
            }
            con.Close();
        }
    }
}