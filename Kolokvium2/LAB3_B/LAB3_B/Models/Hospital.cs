using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LAB3_B.Models
{
    public class Hospital
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "The patient's name is required")]
        [DisplayName("Hospital's name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "The hospital's address is required")]
        public string Address { get; set; }
        public string Phone { get; set; }

        public string ImageUrl { get; set; }
    }
}