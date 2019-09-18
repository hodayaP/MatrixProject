using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace MatrixProject
{
    public partial class SessionStorage : System.Web.UI.Page
    {
        public List<string> bookMarkNames { get; set; }
        public List<string> bookMarkUrls { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            bookMarkNames = (Session["bookMarkName"] as List<string>) ?? new List<string>();
            bookMarkUrls = (Session["bookMarkUrl"] as List<string>) ?? new List<string>();
            if (Request.QueryString["repositories"]!=null)
            {
                for (int i = 0; i < bookMarkNames.Count; i++)
                {
                    HyperLink link1 = new HyperLink();
                    link1.ID = "link" + i.ToString();
                    link1.Text = bookMarkNames[i];
                    link1.NavigateUrl = bookMarkUrls[i];
                    form1.Controls.Add(link1);
                    details.Visible = true;
                }
            }
            else
            {              
                if (Request.QueryString["name"] != null)
                {
                    bookMarkNames.Add(Request.QueryString["name"]);
                    Session["bookMarkName"] = bookMarkNames;
                }
                if (Request.QueryString["htmlUrl"] != null)
                {
                    bookMarkUrls.Add(Request.QueryString["htmlUrl"]);
                    Session["bookMarkUrl"] = bookMarkUrls;
                }
            }
           

        }
    }
}