using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BioFortStat.Models
{
    public class RoleModel
    {
        public string Id { get; set; }
        [StringLength(25)]
        public string Name { get; set; }
        public RoleModel()
        {

        }

        public RoleModel(ApplicationRole role)
        {
            Id = role.Id;
            Name = role.Name;
        }

    }
}