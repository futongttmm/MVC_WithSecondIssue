using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyVidly.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is Required.")]
        [MaxLength(255)]
        public string Name { get; set; }

        [Display(Name = "Release Date")]
        public DateTime? ReleaseDate { get; set; }

        [Display(Name = "Add Date")]
        public DateTime? AddDate { get; set; }
        public Genre Genre { get; set; }

        [Required(ErrorMessage = "Genre is required")]
        [Display(Name = "Genres")]
        public int GenreId { get; set; }

        [Display(Name = "Number in Stock")]
        [Range(1, 20)]
        public int Number { get; set; }
        public int AvailableNumber { get; set; }



    }
}