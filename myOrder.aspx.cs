using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication3.DataSet1TableAdapters;

namespace WebApplication3
{
    public partial class myOrder : System.Web.UI.Page
    {
        DataTable2Table order = new DataTable2Table();
        protected void Page_Load(object sender, EventArgs e)
        {
            string Uname = Context.User.Identity.Name;
            var orderData = order.GetOrderData(Uname);
            for (int i = 0; i < orderData.Rows.Count; i++)
            {
                if (Convert.ToString(orderData.Rows[i]["ispay"]) == "0")
                {
                    orderData.Rows[i]["ispay"] = "未支付";
                }
                else
                {
                    orderData.Rows[i]["ispay"] = "已支付";
                }
            }
            GridView1.DataSource = orderData;
            GridView1.DataBind();
            
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            LinkButton bt1=(LinkButton)sender;
            int arg = Convert.ToInt32(bt1.CommandArgument.ToString());
            Response.Redirect("pay.aspx?Oid=" + arg + "");
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            LinkButton bt2 = (LinkButton)sender;
            string arg =bt2.CommandArgument.ToString();
            Response.Redirect("pay.aspx?Fname=" + arg + "");
        }
    }
}