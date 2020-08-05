using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BioFortStat.Dto
{
    public class PriceDto
    {
        public int Id { get; set; }
        public string MarketName { get; set; }
        public string ProductName { get; set; }
        public string ProductQuantity { get; set; }
        public string ProductPrice { get; set; }
        public bool SameasPrevious { get; set; }
        public string CreatedBy { get; set; }
        public string Unit { get; set; }
        public DateTime PickedDate { get; set; }
        public DateTime CreatedDate { get; set; }

    }
}