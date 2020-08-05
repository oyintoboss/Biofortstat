using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BioFortStat.Models
{
    public class Crop
    {
        public int Id { get; set; }
        [StringLength(15)]
        public string CropName { get; set; }
    }
}