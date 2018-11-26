using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineShop2
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                SqlConnection conn = new SqlConnection(@"Data Source = DESKTOP-ADUB1NO\SQLEXPRESS; Initial Catalog =OnlineShop; Integrated Security = True");
                conn.Open();

                string viewProducts = "SELECT files, car_name, price, added_date from CARS";
                SqlDataAdapter sda = new SqlDataAdapter(viewProducts, conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                GridView1.DataSource = dt;
                GridView1.DataBind();

                conn.Close();
            }
        }

        protected void OnRowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                DataRowView dr = (DataRowView)e.Row.DataItem;
                string imageUrl = "data:image/jpg;base64," + Convert.ToBase64String((byte[])dr["Files"]);
                (e.Row.FindControl("car_image") as Image).ImageUrl = imageUrl;
            }
        }

        protected void ImgButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Order.aspx");
        }
    }
}