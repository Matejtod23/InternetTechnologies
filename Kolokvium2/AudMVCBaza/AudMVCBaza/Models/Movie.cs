using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AudMVCBaza.Models
{
    public class Movie
    {
        public Movie() 
        {
            Clients = new List<Client>();
        }
        public int Id { get; set; }
        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Display(Name = "Url za prezemanje")]

        public string DownloadUrl { get; set; }
        public string ImageUrl { get; set; }
        public float Rating { get; set; }
        public virtual List<Client> Clients { get; set; }
    }
}