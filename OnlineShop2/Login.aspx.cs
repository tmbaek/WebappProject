using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace OnlineShop2
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source = DESKTOP-ADUB1NO\SQLEXPRESS; Initial Catalog =OnlineShop; Integrated Security = True");
            conn.Open();
            
            string checkuser = "select count(*) from USERS where username=@userid AND passwd=@passwd";
            SqlCommand cmd = new SqlCommand(checkuser, conn);
         
            cmd.Parameters.AddWithValue("@userid", TextBox1.Text);
            cmd.Parameters.AddWithValue("@passwd", TextBox2.Text);
            int count = Convert.ToInt32(cmd.ExecuteScalar().ToString());
            if (count == 1)
            {
                Session["username"] = TextBox1.Text;
                Response.Redirect("Default.aspx");
            }

            conn.Close();
        }
    }
}