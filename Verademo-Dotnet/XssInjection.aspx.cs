using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Verademo_dotnet
{
    public partial class XssInjection : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["text"] != null)
            {
                // Response.Write(Request.QueryString["text"]);

                Response.Write(System.Net.WebUtility.HtmlEncode(Request.QueryString["text"]));
            }
        }
    }
}