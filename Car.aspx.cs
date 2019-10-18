using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication3.DataSet1TableAdapters;

namespace WebApplication3
{
    public partial class Car : System.Web.UI.Page
    {
        FixedTable fixeddata = new FixedTable();
        FpriceTable fpricedata = new FpriceTable();
        DataTable2Table dataTable1 = new DataTable2Table();
        protected void Page_Load(object sender, EventArgs e)
        {
            bind();
            if (Labelsum.Text == null)
            {
                Labelsum.Text = (Convert.ToInt32(Labelprice.Text) * Convert.ToInt32(TextBox1.Text)).ToString();
            }
        }
        void bind()
        {
            if (!IsPostBack)
            {
                string num = Request.QueryString["num"];
                TextBox1.Text = num;
                string Fname = Request.QueryString["Fname"];
                string type = Request.QueryString["ddl"];
                var aaadata = fixeddata.GetinfoFixed(Fname);
                Labeluname.Text = Session["Uname"].ToString();
                Labelfixed.Text = Fname;
                Labeltype.Text = type;
                var bbbdata = fpricedata.GetDDlSelected(type);
                Labelprice.Text = bbbdata.Rows[0]["price"].ToString();
                if (Labelsum.Text==null)
                {
                    Labelsum.Text=(Convert.ToInt32(Labelprice.Text) * Convert.ToInt32(TextBox1.Text)).ToString();
                }
            }
            else
            {
                string Fname = Request.QueryString["Fname"];
                string type = Request.QueryString["ddl"];
                var aaadata = fixeddata.GetinfoFixed(Fname);
                Labeluname.Text = Session["Uname"].ToString();
                Labelfixed.Text = Fname;
                Labeltype.Text = type;
                var bbbdata = fpricedata.GetDDlSelected(type);
                Labelprice.Text = bbbdata.Rows[0]["price"].ToString();
            }
            
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            Labelsum.Text = (Convert.ToInt32(Labelprice.Text) * Convert.ToInt32(TextBox1.Text)).ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string Fname = Labelfixed.Text;
            var fiddatasum = fixeddata.SesectFidByFname(Fname);
            int fid = Convert.ToInt32 (fiddatasum.Rows[0]["Fid"]);
            String Uname = Session["Uname"].ToString(); ;
            int Fprice = Convert.ToInt32(Labelprice.Text);
            int Onum = Convert.ToInt32(TextBox1.Text);
            int Osum =(Convert.ToInt32(Labelprice.Text) * Convert.ToInt32(TextBox1.Text));
            DateTime date = Calendar1.SelectedDate;
            dataTable1.InsertOrder(Uname,Fprice,Onum,Osum,fid,date);
            ClientScript.RegisterStartupScript(this.GetType(),"","<script language='javascript'>alert('添加订单成功')</script>");
        }
    }
}
