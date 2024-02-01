using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assign_2mvc.Controllers
{
    public class CustomController : Controller
    {
        // GET: Custom
        public ActionResult Index()
        {
            ViewBag.msg = "These are the Customers";
            List<string> list = new List<string>
            {"Robert",
            "George",
            "Anabell",
            "Nitin",
            "Deepak"
                    };
            ViewBag.nameList = list;
            return View();
        }
        public ActionResult RedirectDemo()
        {
            TempData["displaymsg"] = "Thanks for visiting us!!!";
            return View();
        }
    }
}