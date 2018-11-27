using System;
using System.Collections.Generic;
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
            string unitprice = Request.QueryString["unitPrice"].ToString();
            string qty = Request.QueryString["qty"].ToString();
            string totalprice = Request.QueryString["totalPrice"].ToString();

            TextBox1.Text = carid;
            TextBox2.Text = unitprice;
            TextBox3.Text = qty;
            TextBox4.Text = totalprice;
        }
    }
}