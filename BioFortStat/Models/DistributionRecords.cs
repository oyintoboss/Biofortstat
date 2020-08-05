using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BioFortStat.Models
{
    public class DistributionRecords
    {
        public int Id { get; set; }
        [StringLength(15)]
        public string Crop { get; set; }
        [StringLength(15)]
        public string Indicator { get; set; }

        public int Year { get; set; }
        [StringLength(15)]
        public string State { get; set; }
        public int Value { get; set; }
        [StringLength(25)]
        public string createdUser { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}