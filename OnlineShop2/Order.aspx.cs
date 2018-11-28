using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace OnlineShop2
{
    public partial class Order : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source = DESKTOP-ADUB1NO\SQLEXPRESS; Initial Catalog =OnlineShop; Integrated Security = True");
            conn.Open();

            string viewProducts = "SELECT files, car_id, car_name, price, added_date from CARS where car_name='" + Request.QueryString["model"] + "'";
            SqlDataAdapter sda = new SqlDataAdapter(viewProducts, conn);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                byte[] imagedata = (byte[])ds.Tables[0].Rows[0]["files"];
                string img = Convert.ToBase64String(imagedata, 0, imagedata.Length);
                Image1.ImageUrl = "data:image/jpg;base64," + img;
                TextBox1.Text = ds.Tables[0].Rows[0]["car_id"].ToString();
                TextBox2.Text = ds.Tables[0].Rows[0]["car_name"].ToString();
                TextBox3.Text = ds.Tables[0].Rows[0]["price"].ToString();
                TextBox4.Text = ds.Tables[0].Rows[0]["added_date"].ToString();
            }

            conn.Close();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string carID = TextBox1.Text;
            string carname = TextBox2.Text;
            string unitPrice = TextBox3.Text;
            string qty = DropDownList1.SelectedValue;
            double totalPrice = Convert.ToDouble(unitPrice) * Convert.ToInt32(qty);
            Response.Redirect("ItemsofOrder.aspx?carID=" + carID
                              + "&carname=" + carname
                              + "&unitPrice=" + unitPrice 
                              +"&qty=" + qty
                              +"&totalPrice=" + totalPrice);
        }
    }
}