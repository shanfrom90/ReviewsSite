﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewsSite.Models
{
    public class Musical
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public string Description { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }

        public Musical()
        {

        }
        public Musical(int id, string title, string genre, string description, int rating, string comment)
        {
            Id = id;
            Title = title;
            Genre = genre;
            Description = description;
            Rating = rating;
            Comment = comment;
        }
    }
   
}