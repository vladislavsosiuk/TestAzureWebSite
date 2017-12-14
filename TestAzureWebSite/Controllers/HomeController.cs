using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataLayer;

namespace TestAzureWebSite.Controllers
{
    public class HomeController : Controller
    {
        Model context;
        public HomeController()
        {
            context = new Model();
        }
        // GET: Home
        public ActionResult Index()
        {
            var users = context.WorkerInfo.ToList();
            return View(users);
        }
    }
}