using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BioFortStat.Dto
{
    public class BuyerAndSellerDto
    {
        public int Id { get; set; }
        public string CategoryValue { get; set; }
        public string Product { get; set; }
        public int Quantity { get; set; }
        public string Unit { get; set; }
        public DateTime Availability { get; set; }
        public string Price { get; set; }
        public string Village { get; set; }
        public string LGAValue { get; set; }
       // public string ProfilePicture { get; set; }
      //  public int ZipCode { get; set; }
        public string State { get; set; }
        public bool Negotiable { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool Status { get; set; }
    }
}