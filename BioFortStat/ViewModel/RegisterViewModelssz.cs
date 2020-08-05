using BioFortStat.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BioFortStat.ViewModel
{
    public class RegisterViewModelssz
    {
        public RegisterViewModel RegisterViewModelsz { get; set; }
        public string Id { get; set; }
        public string RoleName { get; set; }

        public List<RoleModel> RoleModelz { get; set; }
    }
}