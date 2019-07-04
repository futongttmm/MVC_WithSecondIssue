using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyVidly.Models
{
    public class Rental
    {
        public int Id { get; set; }

        // in this many-to-many relationship, why we don't need to write ICollection for those navigation properties?
        [Required]
        public Customer Customer { get; set; }
        [Required]
        public Movie Movies { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime? ReturnDate { get; set; }
    }
}