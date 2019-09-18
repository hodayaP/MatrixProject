using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace MatrixProject
{
    public partial class MyRepositories : System.Web.UI.Page
    {
        List<string> names;
        List<string> urls;
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Redirect("~/SessionStorage.aspx?repositories=true");         
        }
    }
}