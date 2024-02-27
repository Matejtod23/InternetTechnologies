using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Playtopia.Models
{
    public class Game
    {
        public Game()
        {
            Customers = new List<Customer>();
        }
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        [DisplayName("Price")]
        public int price { get; set; }
        public virtual List<Customer> Customers { get; set; }

    }
}