using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MovieApp.Models
{
    public class Min18YearsIfAMember : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var customer = (Customer)validationContext.ObjectInstance;
            if (customer.MembershipTypeId== (byte)AppEnums.AppEnums.MembershipTypes.Unknown || customer.MembershipTypeId == (byte)AppEnums.AppEnums.MembershipTypes.PayAsUGo)
            {
                return ValidationResult.Success;
            }

            if (customer.Birthdate == null)
            {
                return new ValidationResult("Birth Date is required");
            }

            var age = DateTime.Now.Year - customer.Birthdate.Value.Year;
            return (age > 18)
                ? ValidationResult.Success
                : new ValidationResult("Customer should be atleast 18 years old to go on a membership");
        }
    }
}