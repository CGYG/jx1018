using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication3.DataSet1TableAdapters;

namespace WebApplication3
{
    public partial class _Default : Page
    {
        FixedTable fixedTable = new FixedTable();
        FimgTableAdapter fimgtable = new FimgTableAdapter();
        protected void Page_Load(object sender, EventArgs e)
        {
            var FixedData = fixedTable.GetFixedData();
            int Fimgid = Convert.ToInt32(FixedData[0]["Fimgid"]);
            var img = fimgtable.GetIndeximg(Fimgid);
            DataList1.DataSource = img;
            DataList1.DataBind();
        }
    }
}