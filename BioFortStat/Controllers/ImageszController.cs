using BioFortStat.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BioFortStat.Controllers
{
    public class ImageszController : Controller
    {
        private ApplicationDbContext _context;

        public ImageszController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: Imagesz
        [HttpGet]
        public ActionResult AddImage()
        {
            return View();
        }

        public ActionResult CarouselImage()
        {
            var data = (from d in _context.ImagesBioz select d).ToList();
            
            return View(data);
        }

        [HttpPost]
        public ActionResult AddImage(HttpPostedFileBase Burn, ImagesBio ipath)
        {
            string filename = Path.GetFileNameWithoutExtension(Burn.FileName);
            string extension = Path.GetExtension(Burn.FileName);
            filename = filename + DateTime.Now.ToString("yymmffff") + extension;
            ipath.ImagePath = "~/Images/" + filename;
            filename = Path.Combine(Server.MapPath("~/Images/"), filename);
            Burn.SaveAs(filename);
            _context.ImagesBioz.Add(ipath);
            _context.SaveChanges();
            
            return View();
        }
    }
}