using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BioFortStat.Controllers
{
    public class DistributionRecordsController : Controller
    {
        // GET: DistributionRecords
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CreateDistRecord()
        {
            return View();
        }

        public ActionResult New()
        {
            return View("CreateDistRecord");
        }
    }
}