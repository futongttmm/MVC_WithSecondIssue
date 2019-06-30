using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyVidly.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Display(Name = "Date of Brith")]
        public DateTime? Birthdate { get; set; }
        public bool IsSubcribeToNewsletter { get; set; }
        public MembershipType Membership { get; set; }

        [Display(Name = "Membership Type")]
        public int MembershipTypeId { get; set; }
        
    }
}