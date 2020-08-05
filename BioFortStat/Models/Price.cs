using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BioFortStat.Models
{
    public class Price
    {
        public int Id { get; set; }
        [StringLength(15)]
        public string MarketName { get; set; }
        [StringLength(15)]
        public string ProductName { get; set; }
        [StringLength(10)]
        public string ProductQuantity { get; set; }
        [StringLength(10)]
        public string ProductPrice { get; set; }
        public bool SameasPrevious { get; set; }
        [StringLength(25)]
        public string CreatedBy { get; set; }
        [StringLength(15)]
        public string Unit { get; set; }
        public DateTime PickedDate { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}