using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectHealth
{
    public partial class homepage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(DropDownList1.Text=="Sta Ana")
            {
               // Response.Write("<script>alert('Welcome to BRGY Sta Ana ')</script>");
            Response.Write("<script>alert('Welcome to Barangay Sta Ana');window.location = 'staana.aspx';</script>"); //works great    
            //Response.Redirect("staana.aspx");
            }
            else if (DropDownList1.Text == "Tuktukan")
            {
                Response.Write("<script>alert('Welcome to Barangay Tuktukan');window.location = 'tuktukan.aspx';</script>"); //works great    
                // Response.Redirect("tuktukan.aspx");
            }
            else if (DropDownList1.Text == "Hagonoy")
            {
                Response.Redirect("hagonoy.aspx");
            }
            
        }

        protected void admin_Click(object sender, ImageClickEventArgs e)
        {
            Response.Write("<script>alert('Admin Login Page');window.location = 'login.aspx';</script>"); //works great    
                                                                                                                         // Response.Redirect("tuktukan.aspx");
        }
    }
}