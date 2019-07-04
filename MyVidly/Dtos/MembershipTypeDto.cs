using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyVidly.Dtos
{
    public class MembershipTypeDto
    {
        //There's no need to add all membership type properties here because if a client wants to know the details
        //about a given membership type they can use the ID here to send a request to potential a new endpoint
        //for membership types.So if we want to keep this lightweight
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        
    }
}