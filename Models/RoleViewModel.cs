using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TeamComeback.Models
{
    public class RoleViewModel
    {
        public RoleViewModel() { }
        public RoleViewModel(ApplicationRole role)
        {
            Id = role.Id;
            Name = role.Name;
        }
        public string Id { get; set; }
        [Display(Name = "Role")]
        public string Name { get; set; }
    }
}