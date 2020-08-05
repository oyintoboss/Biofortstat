using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BioFortStat.Models
{
    public class Product
    {   
        public int Id { get; set; }
        [StringLength(15)]
        public string ProductName { get; set; }
        [StringLength(10)]
        public string ProductPrice { get; set; }

        public State StateTypes { get; set; }

        public ProductUnit UnitTypes { get; set; }

        public int ProductQuantity { get; set; }
        [StringLength(10)]
        public string ProductUnit { get; set; }  
        [StringLength(15)]      
        public string State { get; set; }
        [StringLength(15)]
        public string LGA { get; set; }
        //public int ZipCode { get; set; }
        [StringLength(200)]
        public string ProductPicture { get; set; }
        public DateTime CreatedDate { get; set; }

    }
}