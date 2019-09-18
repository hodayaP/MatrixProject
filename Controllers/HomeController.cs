using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;

namespace MatrixProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult StoreToSession(string name,string htmlUrl)
        {
            if (name != string.Empty)
            {
                var bookMarkNames = (Session["bookMarkName"] as List<string>) ?? new List<string>();
                bookMarkNames.Add(name);
                Session["bookMarkName"] = bookMarkNames;
            }
            if (name != string.Empty)
            {
                Session["bookMarkUrl"] = htmlUrl;
                var bookMarkUrls = (Session["bookMarkUrl"] as List<string>) ?? new List<string>();
                bookMarkUrls.Add(name);
                Session["bookMarkUrl"] = bookMarkUrls;
            }
            return View();
        }
    }
}