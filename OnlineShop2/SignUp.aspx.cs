using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace OnlineShop2
{
    public partial class Signup : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source = DESKTOP-LIVORGS\SQLEXPRESS; Initial Catalog =OnlineShop; Integrated Security = True");
                conn.Open();
                string insert = "insert into USERS (Username, Passwd, First_Name, LastName) values (@Username, @Passwd, @First_Name, @LastName)";
                SqlCommand cmd = new SqlCommand(insert, conn);
                cmd.Parameters.AddWithValue("@Username", TextBox1.Text);
                cmd.Parameters.AddWithValue("@Passwd", TextBox2.Text);
                cmd.Parameters.AddWithValue("@First_Name", TextBox3.Text);
                cmd.Parameters.AddWithValue("@LastName", TextBox4.Text);
                cmd.ExecuteNonQuery();
                Response.Redirect("Default.aspx");
                conn.Close();
            }
            catch (Exception ex)
            {
                Response.Write(ex);
            }
        }

       
    }
}