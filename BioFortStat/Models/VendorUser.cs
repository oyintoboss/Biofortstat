using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BioFortStat.Models
{
    public class VendorUser
    {
        public int Id { get; set; }
        [StringLength(15)]
        [Display(Name ="First Name")]
        public string FirstName { get; set; }
        [StringLength(15)]
        [Display(Name ="Last Name")]
        public string LastName { get; set; } 
        [Display(Name ="Gender")]       
        public string GenderTypez { get; set; }
        public Gender Gender { get; set; }
        [StringLength(20)]
        [Display(Name ="Phone Number")]
        public string PhoneNumber { get; set; }
        [StringLength(25)]
        [Display(Name ="Business Name")]
        public string BusinessName { get; set; }
        [StringLength(50)]
        [Display(Name ="Business Address")]
        public string BusinessAddress { get; set; }
        [StringLength(70)]
        [Display(Name ="Product Sold")]
        public string ProductSold { get; set; }
        public string ProfilePicture { get; set; }
        [StringLength(30)]
        [Display(Name ="LGA")]
        public string LGA { get; set; }
        [StringLength(20)]
        [Display(Name ="State")]
        public string State { get; set; }
        [StringLength(35)]
        [Display(Name ="Village / Town")]
        public string Village { get; set; }
        public State StateType { get; set; }
        public DateTime CreatedDate { get; set; }

                                          

    }
}