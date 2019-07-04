using MyVidly.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyVidly.ViewModels
{
    public class MovieGenreViewModel
    {
        public IEnumerable<Genre> Genres { get; set; }
        public Movie Movie { get; set; }
    }
}