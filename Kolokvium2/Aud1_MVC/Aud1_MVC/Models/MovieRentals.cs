﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Aud1_MVC.Models
{
    public class MovieRentals
    {
        public Movie movie { get; set;}

        public List<Client> clients { get; set;}

        public MovieRentals()
        {
            clients = new List<Client>();
        }
    }
}