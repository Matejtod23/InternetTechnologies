using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Playtopia.Models
{
    public class Customer
    {
        public Customer()
        {
            Games = new List<Game>();
        }
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public virtual List<Game> Games { get; set; }
    }
}