using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BioFortStat.Controllers
{
    public class MarketController : Controller
    {
        // GET: Market
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CreateMarket()
        {
            return View();
        }

        public ActionResult MarketChart()
        {
            return View();
        }

        public ActionResult New()
        {
            return View("CreateMarket");            
        }

    }
}