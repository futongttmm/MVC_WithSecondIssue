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
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        [StringLength(255)]
        public string Name { get; set; }

        [Display(Name = "Date of Brith")]
        [Min18YearIfAMember]
        public DateTime? Birthdate { get; set; }
        public bool IsSubcribeToNewsletter { get; set; }



        public MembershipType Membership { get; set; }

        //MembershipTypeId is implicitly required, because its type is int
        //if its type is nullable int (int?), it will be optional
        //there is no value for the first option, mvc framework cannot find a value for form data
        //and the value will be an empty string, and mvc does not know how to translate an empty string to an int
        [Display(Name = "Membership Type")]
        public int MembershipTypeId { get; set; }

        //0 is the default value if MembershipType is not choosen
        public static readonly int UNKNOWN = 0;
        public static readonly int PAYASYOUGO = 5;
        
    }
}