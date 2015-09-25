using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GithubTest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //this is to test changes to development branch
            return View();
        }
    }
}
