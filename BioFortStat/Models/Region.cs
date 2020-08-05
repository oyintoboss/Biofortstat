using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BioFortStat.Models
{
    public class Region
    {
        public int Id { get; set; }
        [StringLength(5)]
        public string ZoneValue { get; set; }
        [StringLength(15)]
        public string ZoneName { get; set; }
        [StringLength(15)]
        public string State { get; set; }
    }
}