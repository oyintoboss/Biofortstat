using BioFortStat.Models;
using BioFortStat.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BioFortStat.Controllers
{
    public class UserInfoController : Controller
    {
        private ApplicationDbContext _context;
        public UserInfoController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            // base.Dispose(disposing);
            _context.Dispose();
        }
        // GET: UserInfo
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CreateUser()
        {
            return View();
        }
        
        public ActionResult SaveUser()
        {
            return View();
        }

        public ActionResult VendorList()
        {
            return View();
        }

        public ActionResult UserVendor()
        {
            try
            {
                var state = _context.Statez.ToList();
                var gender = _context.Genderz.ToList();

                var viewModel = new VendorViewModel
                {
                    Statez = state,
                    Genderz = gender
                };

                 return View("UserVendor", viewModel);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.Data);
                Console.WriteLine(ex.Message);
                // throw;
            }
            return View();
        }
        [HttpPost]
        public ActionResult SaveVendor(VendorUser VendorTypez)
        {
            VendorTypez.CreatedDate = DateTime.UtcNow;
            if (!ModelState.IsValid)
            {
                var viewModel = new VendorViewModel
                {
                   VendorTypez = VendorTypez
                };

            }
            Session["FirstName"] = VendorTypez.FirstName;
            if (VendorTypez.Id == 0) _context.VendorUserz.Add(VendorTypez);
            else
            {
                var vendorInDb = _context.VendorUserz.SingleOrDefault(v => v.Id == VendorTypez.Id);
                vendorInDb.FirstName = VendorTypez.FirstName;
                vendorInDb.LastName = VendorTypez.LastName;
                vendorInDb.BusinessAddress = VendorTypez.BusinessAddress;
                vendorInDb.BusinessName = VendorTypez.BusinessName;
                vendorInDb.CreatedDate = VendorTypez.CreatedDate;
                vendorInDb.Gender = VendorTypez.Gender;
                vendorInDb.State = VendorTypez.State;
                vendorInDb.ProductSold = VendorTypez.ProductSold;
                vendorInDb.ProfilePicture = VendorTypez.ProfilePicture;
                vendorInDb.LGA = VendorTypez.LGA;
            }

            _context.SaveChanges();

            var desess = Session["FirstName"].ToString();
            return RedirectToAction("Index", "BiofortStat");
        }

        public ActionResult Edit(int id)
        {
           // var userz = _context.Userz.SingleOrDefault(c => c.Id == id); 
            return View("CreateUser");
        }

        public ActionResult New()
        {
            return View("CreateUser");
        }

        //ChangePassword
        //public ActionResult ChangePassword()
        //{
        //    return View();
        //}
    }
}