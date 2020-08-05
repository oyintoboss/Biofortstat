using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BioFortStat.Models
{
    public class LGA
    {
        public int Id { get; set; }
        [StringLength(10)]
        public string LGAValue { get; set; }
        [StringLength(15)]
        public string LGAName { get; set; }
    }
}