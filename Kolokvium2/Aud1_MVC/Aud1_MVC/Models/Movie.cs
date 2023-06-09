﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Aud1_MVC.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public string DownloadUrl { get; set; }
        public string ImageUrl { get; set; }
        public float Rating { get; set; }
    }
}