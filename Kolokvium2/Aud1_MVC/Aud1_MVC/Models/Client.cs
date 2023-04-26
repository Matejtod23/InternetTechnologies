using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Aud1_MVC.Models
{
    public class Client
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        [Required]
        public string Address { get; set; }
        public string phone { get; set; }
        public string ClientsCard { get; set; }
        [Required]
        [Range(1, 99, ErrorMessage = "Age must be berween 1 and 99")]
        public int Age { get; set; }
        
    }
}