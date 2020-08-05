using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BioFortStat.Dto
{
    public class VendorDto
    {
        public int Id { get; set; }
        
        public string FirstName { get; set; }
       
        public string LastName { get; set; }
       
        public string GenderTypez { get; set; }
       
        
        public string PhoneNumber { get; set; }
       
        public string BusinessName { get; set; }
       
        public string BusinessAddress { get; set; }
       
        public string ProductSold { get; set; }
        public string ProfilePicture { get; set; }
        
        public string LGA { get; set; }
        public string Village { get; set; }

        public string State { get; set; }
        
        public DateTime CreatedDate { get; set; }
    }
}