using BioFortStat.Models;
using BioFortStat.ViewModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BioFortStat.Controllers
{
    public class ProductController : Controller
    {
        private ApplicationDbContext _context;

        public ProductController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CreateProduct()
        {
            return View();
        }

       

        public ActionResult ProductList()
        {
            return View();
        }

        public ActionResult ProductChart()
        {
            return View();
        }

        public ActionResult Edit()
        {
            return View();
        }

        public ActionResult UserProduct()
        {
            var unitx = _context.Unitz.ToList();
            var statex = _context.Statez.ToList();

            var viewModel = new ProductViewModel
            {
                Statez = statex,
                Unitz = unitx
            };
            return View("UserProduct", viewModel);
        }

        public ActionResult New()
        {
            return View("CreateProduct");
        }

        [HttpPost]
        public ActionResult SaveProduct(HttpPostedFileBase product, Product productz)
        {
            productz.CreatedDate = DateTime.Today;
            if (!ModelState.IsValid)
            {
                var viewModel = new ProductViewModel
                {
                    Productz = productz
                };

            }

            string filename = Path.GetFileNameWithoutExtension(product.FileName);
            string extension = Path.GetExtension(product.FileName);
            filename = filename + DateTime.Now.ToString("yymmffff") + extension;
            productz.ProductPicture = "~/ProductImage/" + filename;
            filename = Path.Combine(Server.MapPath("~/ProductImage/"), filename);
            product.SaveAs(filename);
           // _context.ImagesBioz.Add(ipath);
           // _context.SaveChanges();

            //return View();

            //Session["FirstName"] = VendorTypez.FirstName;
            if (productz.Id == 0) _context.Productz.Add(productz);
            else
            {
                var productInDb = _context.Productz.SingleOrDefault(o => o.Id == productz.Id);
                productInDb.LGA = productz.LGA;
                productInDb.ProductName = productz.ProductName;
                productInDb.ProductPicture = productz.ProductPicture;
                productInDb.ProductPrice = productz.ProductPrice;
                productInDb.ProductQuantity = productz.ProductQuantity;
                productInDb.ProductUnit = productz.ProductUnit;
                productInDb.State = productz.State;           
            }

            _context.SaveChanges();

            //var desess = Session["FirstName"].ToString();
            return View("Index");
        }
    }
}