using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyVidly.Models
{
    public class Min18YearIfAMember: ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var customer = (Customer)validationContext.ObjectInstance;

            if (customer.MembershipTypeId == Customer.UNKNOWN || customer.MembershipTypeId == Customer.PAYASYOUGO)
                return ValidationResult.Success;

            if (customer.Birthdate == null)
                return new ValidationResult("Birthdate is required.");

            var age = DateTime.Today.Year - customer.Birthdate.Value.Year;

            return age >= 18 ? 
                ValidationResult.Success : 
                new ValidationResult("Customer should at 18 years old to go on a membership");
        }
    }
}