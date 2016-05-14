using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL.WorkWithDb;
using BOL;

namespace StudentsHelper.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            AllDb db = new AllDb();
            db.GroupDb.Insert(new Group(){GroupId = 1, Title = "Moya Gruppa"});
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
    }
}