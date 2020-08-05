using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BioFortStat.Models
{
    public class UserInformation
    {
        public int Id { get; set; }
        [StringLength(15)]
        public string Title { get; set; }
        [StringLength(25)]
        public string FirstName { get; set; }
        [StringLength(25)]
        public string LastName { get; set; }
        [StringLength(25)]
        public string MiddleName { get; set; }
        [StringLength(10)]
        public string Gender { get; set; }
        [StringLength(15)]
        public string Mobile { get; set; }
        [StringLength(15)]
        public string State { get; set; }
        [StringLength(15)]
        public string LGA { get; set; }        
        //public int ZipCode { get; set; }
        [StringLength(200)]
        public string Passport { get; set; }
        public DateTime DateCreated { get; set; }

    }
}