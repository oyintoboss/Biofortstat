using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace BioFortStat.Models
{
    public class ImagesBio
    {
        public int Id { get; set; }
        public string Title { get; set; }
        [DisplayName("Upload File")]
        public string ImagePath { get; set; }
      //  public HttpPostedFileBase ImageFile { get; set; }
                                           // public string FileName { get; set; }
    }
}