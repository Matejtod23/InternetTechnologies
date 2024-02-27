using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Playtopia.Models
{
    public class CustomerGame
    {
        public int GameId { get; set; }
        public Customer customer { get; set; }
        public int CustomerId { get; set; }
        public List<Game> Games { get; set; }

        public CustomerGame()
        {
            Games = new List<Game>();
        }
    }
}