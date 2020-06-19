using System;
using System.Collections.Generic;

namespace Kollokwium_2.Models
{
    public partial class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime? RealeaseDate { get; set; }
        public decimal? Price { get; set; }
        public string Genre { get; set; }
        public string Rating { get; set; }
    }
}
