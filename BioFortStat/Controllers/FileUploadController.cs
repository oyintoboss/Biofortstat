using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BioFortStat.Controllers
{
    public class FileUploadController : Controller
    {
        // GET: FileUpload
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult UploadFiled()
        {
            if (Request.Files.Count > 0)
            {
                try
                {
                    HttpFileCollectionBase files = Request.Files;
                    for (int i = 0; i < files.Count; i++)
                    {
                        HttpPostedFileBase file = files[i];
                        string fname;

                        if (Request.Browser.Browser.ToUpper() == "IE" || Request.Browser.Browser.ToUpper() == "INTERNET EXPLORER")
                        {
                            string[] testfiles = file.FileName.Split(new char[] { '\\'});
                            fname = testfiles[testfiles.Length - 1];
                        }
                        else
                        {
                            fname = file.FileName;
                        }

                        fname = Path.Combine(Server.MapPath("~/ProductUploads/"), fname);
                        file.SaveAs(fname);
                    }
                    return Json("File Upload Successfully!");
                }
                catch (Exception ex)
                {

                    return Json("Error occured. Error details: " + ex.Message);
                }
            }
            else
            {
                return Json("No files selescted.");
            }
           
        }
    }
}