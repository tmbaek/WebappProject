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
                SqlConnection conn = new SqlConnection(@"Data Source = DESKTOP-LIVORGS\SQLEXPRESS; Initial Catalog =OnlineShop; Integrated Security = True");
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

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Select")
            {
                //Determine the RowIndex of the Row whose Button was clicked.
                int rowIndex = Convert.ToInt32(e.CommandArgument);

                //Reference the GridView Row.
                GridViewRow row = GridView1.Rows[rowIndex];

                //Fetch value of Country
                string model = row.Cells[1].Text;
                Response.Redirect("Order.aspx?model=" + model);
                
            }
        }
    }
}