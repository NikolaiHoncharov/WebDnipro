using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebDnipro.Handlers;
using WebDnipro.Models;

namespace WebDnipro.Controllers
{
    public class HomeController : Controller
    {
        readonly ServicesContainer ServicesContainer = new ServicesContainer();
        public ActionResult Index()
        {
            return View(ServicesContainer);
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        //детальная страница
        public ActionResult Details(int id = 1)
        {
            return View(ServicesContainer.GetDetails(id));
        }

        ///POST
        ///
        [HttpPost]
        public ActionResult Contact(MessageFrmUser model)
        {
            if (ModelState.IsValid)
            {
                ServicesContainer.AddMessageDb(model);
                return View();
            }
            else return View(model);
        }
    }
}