using BioFortStat.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BioFortStat.ViewModel
{
    public class BuyerandProductViewModel
    {
        public List<Product> Productz { get; set; }
        public List<BuyerAndSeller> BuyersandSellers { get; set; }
    }
}