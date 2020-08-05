using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BioFortStat.Controllers
{
    public class ProductCategoryController : Controller
    {
        // GET: ProductCategory
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CreateProductCategory()
        {
            return View();
        }

        public ActionResult New()
        {
            return View("CreateProductCategory");
        }
    }
}