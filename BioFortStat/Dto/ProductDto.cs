using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BioFortStat.Dto
{
    public class ProductDto
    {




        public int Id { get; set; }
        public string ProductName { get; set; }
        public string ProductPrice { get; set; }
        public int ProductQuantity { get; set; }
        public string ProductUnit { get; set; }
        public string State { get; set; }
        public string LGA { get; set; }
        public string ProductPicture { get; set; }
        public int ZipCode { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}