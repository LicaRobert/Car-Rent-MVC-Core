using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentWebApp.Models
{
    public class MaxAge : ValidationAttribute
    {
        private int _maxAge;

        public MaxAge(int maxAge)
        {
            this._maxAge = maxAge;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {

            DateTime birthDay = DateTime.Parse(value.ToString());
            DateTime today = DateTime.Today;
            int age = today.Year - birthDay.Year;
            if (birthDay < today.AddYears(+age))
            {
                age++;
            }
            if (age > _maxAge)
            {
                var result = new ValidationResult("You can not sign up because you are over 65 years old.");
                return result;
            }

            return null;
        }

    }
}
