using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication3.DataSet1TableAdapters;

namespace WebApplication3
{
    public partial class info : System.Web.UI.Page
    {

        FixedTable fixeddata = new FixedTable();
        FimgTableAdapter fimgdata = new FimgTableAdapter();
        CommentextTable commentext = new CommentextTable();
        FpriceTable fpricedata = new FpriceTable();
        protected void Page_Load(object sender, EventArgs e)
        {
            string fname = Request.QueryString["Fname"];
            var fixedxsd = fixeddata.GetinfoFixed(fname);
            int Fimgid = Convert.ToInt32(fixedxsd[0]["Fimgid"]);
            var img = fimgdata.GetIndeximg(Fimgid);
            Image1.ImageUrl = img.Rows[0]["Fsrc"].ToString();
            Label1.Text = fixedxsd.Rows[0]["Finfo"].ToString();

            int Fprice = Convert.ToInt32(fixedxsd[0]["Fprice"]);
            var DDLDatadate = fpricedata.GetDDLData(Fprice);
            if (DropDownList1.Items.Count <= 0)
            {
                DropDownList1.Visible = true;
                for (int i = 0; i < DDLDatadate.Rows.Count; i++)
                {
                    string selected = DDLDatadate.Rows[i]["Pname"].ToString();
                    ListItem item = new ListItem(selected);
                    DropDownList1.Items.Add(selected);
                }
                DropDownList1.SelectedIndex = 0;
                Label5.Text = DDLDatadate.Rows[0]["Ptext"].ToString();
                Label6.Text = DDLDatadate.Rows[0]["Price"].ToString();
                Label7.Text = DDLDatadate.Rows[0]["Priceplus"].ToString();
                Label8.Text = DDLDatadate.Rows[0]["Pnum"].ToString();
                Label9.Text = DDLDatadate.Rows[0]["Psy"].ToString();
            }
            Label2.Text = fixedxsd.Rows[0]["Fname"].ToString();
            Label3.Text = fixedxsd.Rows[0]["Ftime"].ToString();
            Label4.Text = fixedxsd.Rows[0]["Faddress"].ToString();
            Image2.ImageUrl = fixedxsd.Rows[0]["Fmap"].ToString();
            int Fid = Convert.ToInt32(fixedxsd[0]["Fid"]);
            var comment = commentext.GetCommentByFid(Fid);
            DataList1.DataSource = comment;
            DataList1.DataBind();
        }

        protected void DropDownList1_TextChanged(object sender, EventArgs e)
        {
            var ddl = fpricedata.GetDDlSelected(DropDownList1.SelectedValue);
            Label5.Text = ddl.Rows[0]["Ptext"].ToString();
            Label6.Text = ddl.Rows[0]["Price"].ToString();
            Label7.Text = ddl.Rows[0]["Priceplus"].ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string fname = Label2.Text;
            string ddl = DropDownList1.SelectedValue;
            string num = TextBox1.Text;
            Response.Redirect("car.aspx?Fname=" + fname + "&ddl=" + ddl + "&num="+num+"");
        }
    }
}