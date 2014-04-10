using System;
using System.Data;

namespace Web
{
    public partial class rank : System.Web.UI.Page
    {
        rankDB rankDb = new rankDB();

        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet ds = rankDb.getRank();
            rpt_score.DataSource = ds.Tables[0];
            rpt_score.DataBind();
        }
    }
}