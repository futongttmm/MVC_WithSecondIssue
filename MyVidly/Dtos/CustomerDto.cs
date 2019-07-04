using MyVidly.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyVidly.Dtos
{
    public class CustomerDto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        [StringLength(255)]
        public string Name { get; set; }

        [Display(Name = "Date of Brith")]
        // [Min18YearIfAMember]
        public DateTime? Birthdate { get; set; }
        public bool IsSubcribeToNewsletter { get; set; }


        // we should exclude this MembershipType, because this is a domain class, and this property here is creating
        //dependency from our DTL to our domain model.
        //So if we change this membership type these can impact our DTO.
        //So here we either use primitive types like integer, string, byte whatever or custom DTOs.
        //So if you want to return hierarchical data structures you would created another type called membershiptype DTO.

        // public MembershipType Membership { get; set; }

        public MembershipTypeDto Membership { get; set; }

        [Display(Name = "Membership Type")]
        public int MembershipTypeId { get; set; }

        //0 is the default value if MembershipType is not choosen
        public static readonly int UNKNOWN = 0;
        public static readonly int PAYASYOUGO = 5;
    }
}