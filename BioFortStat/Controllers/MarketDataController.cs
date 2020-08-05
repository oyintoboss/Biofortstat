using BioFortStat.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BioFortStat.Controllers
{
    public class MarketDataController : Controller
    {
        private ApplicationDbContext _context;
        public MarketDataController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: MarketData
        public ActionResult Index()
        {
            var data = _context.Productz.ToList();
            return View(data);
        }

        public ActionResult DemoChart()
        {
            return View();
        }
    }
}