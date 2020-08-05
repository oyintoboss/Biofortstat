using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BioFortStat.Models
{
    public class BuyerAndSeller
    {
       
       
        public int Id { get; set; }
        [StringLength(15)]
        public string CategoryValue { get; set; }
        [StringLength(20)]
        public string Product { get; set; }
       // [StringLength(10)]
        public int Quantity { get; set; }
        [StringLength(15)]
        public string Unit { get; set; }
        
        public DateTime Availability { get; set; }
        [StringLength(10)]
        public string Price { get; set; }
        [StringLength(25)]
        public string Village { get; set; }
        [StringLength(30)]
        public string LGAValue { get; set; }
        [StringLength(20)]
        public string State { get; set; }
        //[StringLength(50)]
        //public string ProfilePicture { get; set; }
      //  [StringLength(10)]
       // public int ZipCode { get; set; }
       // [StringLength(8)]
        public bool Negotiable { get; set; }
       // [StringLength(20)]
        public DateTime CreatedDate { get; set; }
       // [StringLength(10)]
        public bool Status { get; set; }
    }
}