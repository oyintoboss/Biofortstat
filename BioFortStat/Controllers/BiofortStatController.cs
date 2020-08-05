using BioFortStat.Models;
using BioFortStat.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BioFortStat.Controllers
{
    public class BiofortStatController : Controller
    {
        private ApplicationDbContext _context;

        public BiofortStatController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: BiofortStat
        public ActionResult Index()
        {
            var Buyersandseller = (from d in _context.BuyerAndSellerz select d).ToList();
            var product = (from d in _context.Productz select d).ToList();
            var viewModel = new BuyerandProductViewModel
            {
                Productz = product,
                BuyersandSellers = Buyersandseller
            };
            //BuyerandProductViewModel wrapperModel = new BuyerandProductViewModel();
            //wrapperModel.Productz = _context.Productz; // from your db
            //wrapperModel.Apartments = db.Apartments;// from your db

           
            return View("Index", viewModel);
        }

       
      
    }
}