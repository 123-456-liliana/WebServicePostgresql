using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Personas
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            WebServiceDB.WebService1SoapClient ws = new WebServiceDB.WebService1SoapClient();
            DataSet ds = ws.GetData();
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();

        }
    }
}