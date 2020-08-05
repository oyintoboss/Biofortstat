using BioFortStat.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BioFortStat.ViewModel
{
    public class ProductViewModel
    {
        public Product Productz { get; set; }
        public IEnumerable<State> Statez { get; set; }
        public IEnumerable<ProductUnit> Unitz { get; set; }
    }
}