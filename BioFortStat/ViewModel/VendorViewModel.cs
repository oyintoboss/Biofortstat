using BioFortStat.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BioFortStat.ViewModel
{
    public class VendorViewModel
    {
        public VendorUser VendorTypez { get; set; }
        public IEnumerable<State> Statez { get; set; }
        public IEnumerable<Gender> Genderz { get; set; }
    }
}