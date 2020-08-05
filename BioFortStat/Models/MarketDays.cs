using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BioFortStat.Models
{
    public class MarketDays
    {
        public int Id { get; set; }
        [StringLength(10)]
        public string Days { get; set; }
    }
}