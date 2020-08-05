using BioFortStat.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BioFortStat.Controllers
{
    
   
    public class ImageController : Controller
    {
        private ApplicationDbContext _context;
        public ImageController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: Image
        public ActionResult Index()
        {
            String path = Server.MapPath("~/ProductUploads/");
            String[] imagefiles = Directory.GetFiles(path);
            ViewBag.imagearray = imagefiles;
            return View();
        }

        public ActionResult SsIndex()
        {
            
            return View();
        }

        [HttpGet]
        public ActionResult AddImage()
        {

            return View();
        }

        [HttpPost]
        public ActionResult AddImage(ImagesBio ImagesBioz)
        {
            //var imageName = Path.GetFileNameWithoutExtension(ImagesBioz.FileName);
            //var imageExtension = Path.GetExtension(ImagesBioz.FileName);
            //var fullName = imageName + imageExtension;
            //ImagesBioz.ImagePath = "~/ProductUploads/" + fullName;
            //fullName = Path.Combine(Server.MapPath("~/ProductUploads/" + fullName));
            
            //_context.ImagesBioz.Add(fullName);
            return View();
        }

        public ActionResult CarouselImage()
        {
            String path = Server.MapPath("~/ProductUploads/");
            String[] imagefiles = Directory.GetFiles(path);
            ViewBag.image = imagefiles;
            return View();
        }
    }
}