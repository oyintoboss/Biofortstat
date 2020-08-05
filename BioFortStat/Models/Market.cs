using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BioFortStat.Models
{
    public class Market
    {
        public int Id { get; set; }
        [StringLength(15)]
        public string MarketName { get; set; }
        [StringLength(200)]
        public string MarketDescription { get; set; }
        [StringLength(15)]
        public string MarketDays { get; set; }
        [StringLength(100)]
        public string MainProducts { get; set; }
        [StringLength(15)]
        public string MarketState { get; set; }
        [StringLength(15)]
        public string MarketLGA { get; set; }
    }
}