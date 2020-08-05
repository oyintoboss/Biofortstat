using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BioFortStat.Controllers
{
    public class BuyerandSellerController : Controller
    {
        // GET: BuyerandSeller
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult BuyersChart()
        {
            return View();
        }

        public ActionResult CreateBuyerAndSeller()
        {
            return View();
        }

        public ActionResult BuyerandSellerList()
        {
            return View();
        }

        public ActionResult New()
        {
            return RedirectToAction("CreateBuyerAndSeller");
        }
    }
}