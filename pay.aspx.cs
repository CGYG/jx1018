using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class pay : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            LinkButton lb1 = (LinkButton)sender;
            lb1.PostBackUrl = "~/ispay.aspx";
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            LinkButton lb2 = (LinkButton)sender;
            lb2.PostBackUrl = "~/ispay.aspx?pay=wechat&Oid=" + Request.QueryString["Oid"] + "";
        }
    }
}