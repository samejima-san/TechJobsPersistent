using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using TechJobsPersistent.Models;

namespace TechJobsPersistent.ViewModels
{
    public class AddJobViewModel
    {
        [Required(ErrorMessage = "Name is required")]
        public string JobsName { get; set; }

        public int EmployersId { get; set; }

        public Employer[] SelectListItem { get; set; }
    }
}
