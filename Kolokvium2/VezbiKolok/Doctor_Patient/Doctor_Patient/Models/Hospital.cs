using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Doctor_Patient.Models
{
    public class Hospital
    {
        [Required(ErrorMessage = "The hospital's name is required")]
        [Display(Name = "Hospital Name")]
        public string Name { get; set; }
        [Key]
        public int Id { get; set; }
        [Display(Name = "Hospital Address")]

        public string Address { get; set; }

        public string City { get; set; }

        public string Phone { get; set; }

        public string ImageUrl { get; set; }
    }
}