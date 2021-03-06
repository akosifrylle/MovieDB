﻿using System;

namespace Movie.Core
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public decimal Rating { get; set; }
        public DateTime ReleaseDate { get; set; }
        public Genre Genre { get; set; }
        public ProductionCompany ProductionCompany { get; set; }
    }
}
