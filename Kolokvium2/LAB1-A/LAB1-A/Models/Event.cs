using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LAB1_A.Models
{
    public class Event
    {
        public int Id { get; set; }
        [Required]
        public string ime { get; set; }
        [Required]
        [MinLength(5)]
        [MaxLength(30)]
        public string lokacija { get; set; }

        public List<Event> events { get; set; } = new List<Event>();

    }
}