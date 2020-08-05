using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BioFortStat.Dto
{
    public class UserInfoDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string Gender { get; set; }
        public string Mobile { get; set; }
        public string State { get; set; }
        public string LGA { get; set; }
        
        public int ZipCode { get; set; }

        public string Passport { get; set; }
        public DateTime DateCreated { get; set; }

    }
}