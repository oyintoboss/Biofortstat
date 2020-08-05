using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BioFortStat.Controllers
{
    public class PriceController : Controller
    {
        // GET: Price
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CreatePrice()
        {
            return View();
        }

        public ActionResult New()
        {
            return View("CreatePrice");
        }
    }
}