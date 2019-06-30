using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyVidly.Models
{
    public class MembershipType
    {
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; }
        public int SignUpFee { get; set; }
        public byte DurationMonth { get; set; }
        public byte DiscountRate { get; set; }
    }
}