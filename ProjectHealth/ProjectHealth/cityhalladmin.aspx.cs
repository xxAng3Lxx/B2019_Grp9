using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Web.UI.DataVisualization.Charting;
using System.Drawing;

namespace ProjectHealth
{
    public partial class cityhalladmin : System.Web.UI.Page
    {

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-3AMSICV;Initial Catalog=center;Integrated Security=True");


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //checkuppppppp
                con.Open();

                SqlCommand cmd = new SqlCommand("Select Count(*) From TableCHECKUP", con);
                var count = cmd.ExecuteScalar();
                lblcheckup.Text = count.ToString();

               // SqlCommand cmd4 = new SqlCommand("Select Count(*) From TableCHECKUP WHERE Gender='Male'", con);
                //var count4 = cmd4.ExecuteScalar();
                //lblmale.Text = count4.ToString();

                //SqlCommand cmd6 = new SqlCommand("Select Count(*) From TableCHECKUP WHERE Gender='Female'", con);
                //var count6 = cmd6.ExecuteScalar();
                //lblfemale.Text = count6.ToString();

                SqlCommand cmd2 = new SqlCommand("Select Count(*) From TablePRENATAL", con);
                var count2 = cmd2.ExecuteScalar();
                lblprenatal.Text = count2.ToString();

                SqlCommand cmd5 = new SqlCommand("Select Count(*) From TableILLNESS where NO != 11", con);
                var count5 = cmd5.ExecuteScalar();
                lblcategory.Text = count5.ToString();


                SqlCommand cmd3 = new SqlCommand("Select Count(*) From TableSTAFF", con);
                var count3 = cmd3.ExecuteScalar();
                lblstaff.Text = count3.ToString();

                con.Close();

                //------GRAPH-----------------------


                String query = string.Format("Select Count(*) As countrows,Illness from TableCHECKUP Group by Illness Having(Count(*)>-1)order by Illness desc", "Illness");
                DataTable dt = GetData(query);
                string[] x = new string[dt.Rows.Count];
                int[] y = new int[dt.Rows.Count];

                for (int i = 0; i < dt.Rows.Count; i++)
                {

                    x[i] = dt.Rows[i][1].ToString();
                    y[i] = Convert.ToInt32(dt.Rows[i][0]);
                }
                Chart1.Series[0].Points.DataBindXY(x, y);
                Chart1.Series[0].ChartType = SeriesChartType.Column;
                Chart1.ChartAreas["ChartArea1"].Area3DStyle.Enable3D = false;
                Chart1.Width = 600;
                Chart1.ChartAreas[0].AxisX.LabelStyle.Font = new System.Drawing.Font("Verdana", 8f, System.Drawing.FontStyle.Bold);
                Chart1.ChartAreas[0].AxisY.LabelStyle.Font = new System.Drawing.Font("Verdana", 10, System.Drawing.FontStyle.Bold);
                Chart1.ChartAreas[0].AxisY.LabelStyle.ForeColor = System.Drawing.Color.Black;


                //  Chart1.ChartAreas[0].AxisX.Name("hakhk");

                //Chart1.ChartAreas[0].AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 12);
                //Chart1.Palette = ChartColorPalette.Berry;
                //   Chart1.Legends[0].Enabled = true;

                //------GRAPH-----------------------


                String query2 = string.Format("Select Count(*) As countrowss,Gender from TableCHECKUP Group by Gender Having(Count(*)>-1)order by countrowss asc", "Gender");
                DataTable dt2 = GetData(query2);
                string[] x2 = new string[dt2.Rows.Count];
                int[] y2 = new int[dt2.Rows.Count];

                for (int a = 0; a < dt2.Rows.Count; a++)
                {

                    x2[a] = dt2.Rows[a][1].ToString();
                    y2[a] = Convert.ToInt32(dt2.Rows[a][0]);
                }
                Chart2.Series[0].Points.DataBindXY(x2, y2);
                Chart2.Series[0].ChartType = SeriesChartType.Pie;
                Chart2.ChartAreas["ChartArea2"].Area3DStyle.Enable3D = false;
                Chart2.Width = 400;

                Chart2.ChartAreas[0].AxisY.LabelStyle.ForeColor = System.Drawing.Color.Black;
                Chart2.Legends[0].Enabled = true;
                Chart2.Legends[0].Font = new Font("Verdana", 12);
                Chart2.Series["Series2"].XValueMember = "Gender";
                Chart2.Series["Series2"].YValueMembers = "countrowss";
                Chart2.Series["Series2"].IsValueShownAsLabel = true;

                //------GRAPH-----------------------


                String query3 = string.Format("Select Count(*) As countrowss,Age from TablePRENATAL Group by Age Having(Count(*)>-1)order by Age asc", "Age");
                DataTable dt3 = GetData(query3);
                string[] x3 = new string[dt3.Rows.Count];
                int[] y3 = new int[dt3.Rows.Count];

                for (int b = 0; b < dt3.Rows.Count; b++)
                {

                    x3[b] = dt3.Rows[b][1].ToString();
                    y3[b] = Convert.ToInt32(dt3.Rows[b][0]);

                }
                Chart3.Series[0].Points.DataBindXY(x3, y3);
                Chart3.Series[0].ChartType = SeriesChartType.Line;
                Chart3.ChartAreas["ChartArea3"].Area3DStyle.Enable3D = false;
                Chart3.Width = 1040;

                Chart3.ChartAreas[0].AxisY.LabelStyle.ForeColor = System.Drawing.Color.Black;
                //   Chart3.Legends[0].Enabled = true;
                // Chart3.Legends[0].Font = new Font("Verdana", 12);
                // Chart3.Legends[0].Title = "Women Pregnancy Age";
                Chart3.Series["Series3"].XValueMember = "Age";
                Chart3.Series["Series3"].YValueMembers = "countrowss";
                // Chart3.Series["Series3"].IsValueShownAsLabel = true;

                Chart3.Series["Series3"].Points.DataBindXY(x3, y3);
                Chart3.Series["Series3"].MarkerStyle = MarkerStyle.Square;
                Chart3.Series["Series3"].MarkerSize = 15;
                // Chart3.Series["Series3"].Points[0].MarkerColor = Color.MediumVioletRed;
                Chart3.Series["Series3"].Color = Color.DodgerBlue;


                Chart3.Series["Series3"].BorderWidth = 3;

                Chart3.ChartAreas[0].AxisX.LabelStyle.Font = new System.Drawing.Font("Verdana", 8f, System.Drawing.FontStyle.Bold);
                Chart3.ChartAreas[0].AxisY.LabelStyle.Font = new System.Drawing.Font("Verdana", 10, System.Drawing.FontStyle.Bold);
                Chart3.ChartAreas[0].AxisY.LabelStyle.ForeColor = System.Drawing.Color.Black;







            }
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
            //logout
            Response.Write("<script>alert('Logout Admin');window.location = 'login.aspx';</script>"); //works great    


        }



        //---------------------------
        private static DataTable GetData(string query)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(query);
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-3AMSICV;Initial Catalog=center;Integrated Security=True");

            SqlDataAdapter sda = new SqlDataAdapter();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            sda.SelectCommand = cmd;
            sda.Fill(dt);
            return dt;
        }






    }
}