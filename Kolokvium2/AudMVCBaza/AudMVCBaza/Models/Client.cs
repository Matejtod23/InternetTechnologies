using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AudMVCBaza.Models
{
    public class Client
    {

        public Client() { 
            Movies = new List<Movie>();
        }

        [Required]
        [Key]
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
        
        public virtual List<Movie> Movies { get; set;}
    }
}