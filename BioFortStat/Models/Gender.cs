using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BioFortStat.Models
{
    public class Gender
    {
        public int Id { get; set; }
        [StringLength(3)]
        public string GenderValue { get; set; }
        [StringLength(5)]
        public string GenderName { get; set; }
    }
}