using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineShop2
{
    public partial class ItemsofOrder : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string carid = Request.QueryString["carID"].ToString();
            string carname = Request.QueryString["carname"].ToString();
            string unitprice = Request.QueryString["unitPrice"].ToString();
            string qty = Request.QueryString["qty"].ToString();
            string totalprice = Request.QueryString["totalPrice"].ToString();

            TextBox1.Text = carid;
            TextBox2.Text = carname;
            TextBox3.Text = unitprice;
            TextBox4.Text = qty;
            TextBox5.Text = totalprice;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source = DESKTOP-ADUB1NO\SQLEXPRESS; Initial Catalog =OnlineShop; Integrated Security = True");
            conn.Open();

            int order_id=0;
            string max_order_id = "SELECT MAX(order_id) from OrderList";
            SqlCommand cmd = new SqlCommand(max_order_id, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                order_id = Convert.ToInt32(reader[0]) + 1;
                //order_id = 1;                    
            }
            reader.Dispose();

            if (Session["username"] != null)
            {
                string insertOrder = "INSERT INTO OrderList (order_id, username, car_id, qty, total_price, Order_date) values(@order_id, @username, @car_id, @qty, @total_price, DEFAULT)";
                SqlCommand insertcmd = new SqlCommand(insertOrder, conn);

                insertcmd.Parameters.AddWithValue("@order_id", order_id.ToString());
                insertcmd.Parameters.AddWithValue("@username", Session["username"].ToString());
                insertcmd.Parameters.AddWithValue("@car_id", TextBox1.Text);
                insertcmd.Parameters.AddWithValue("@qty", TextBox4.Text);
                insertcmd.Parameters.AddWithValue("@total_price", TextBox5.Text);
                insertcmd.ExecuteNonQuery();
                insertcmd.Dispose();
                
                Response.Write("<script>alert('Order Placed Successfully.')</script>");
                Server.Transfer("Default.aspx");

            }
            else
            {
                Response.Redirect("login.aspx");
            }

            conn.Close();          
            

        }
    }
}