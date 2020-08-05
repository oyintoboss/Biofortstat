using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BioFortStat.Models
{
    public class ProductCategory
    {
        public int Id { get; set; }
        [StringLength(15)]
        public string ProductName { get; set; }
        [StringLength(15)]
        public string CategoryName { get; set; }
    }
}