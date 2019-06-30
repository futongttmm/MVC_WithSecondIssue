using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyVidly.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public DateTime? AddDate { get; set; }
        public Genre Genre { get; set; }
        public int GenreId { get; set; }
        public int Number { get; set; }
    }
}