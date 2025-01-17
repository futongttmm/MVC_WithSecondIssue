﻿using MyVidly.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyVidly.ViewModels
{
    public class CustomerMembershipViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customer Customer { get; set; }
    }
}