using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BioFortStat.Dto
{
    public class DistributionRecordsDto
    {
        public int Id { get; set; }
        public string Crop { get; set; }
        public string Indicator { get; set; }
        public int Year { get; set; }
        public string State { get; set; }
        public int Value { get; set; }
        public string createdUser { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}