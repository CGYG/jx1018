using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication3.DataSet1TableAdapters;

namespace WebApplication3
{
    public partial class ispay : System.Web.UI.Page
    {
        DataTable2Table dataTable2Table = new DataTable2Table();
        protected void Page_Load(object sender, EventArgs e)
        {
            string pay = Request.QueryString["pay"].ToString();
            int Oid =Convert.ToInt32(Request.QueryString["Oid"]);
            if (pay == "zfb")
            {
                Image1.ImageUrl = "./images/zfb.jpg";
            }
            else
            {
                Image1.ImageUrl = "./images/wechat.jpg";
            }

            dataTable2Table.UpdateisPay(Oid);
            ClientScript.RegisterStartupScript(this.GetType(),"","<script language='javascript'>alert('支付成功')</script>");


        }
    }
}