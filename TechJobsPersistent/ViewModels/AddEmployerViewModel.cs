using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using TechJobsPersistent.Models;

namespace TechJobsPersistent.Models
{
    public class AddEmployerViewModel
    {
        [Required(ErrorMessage = "Location is required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Location is required")]
        public string Location { get; set; }
    }
}
