using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentWebApp.Models
{
    public class MinAge : ValidationAttribute
    {
        private int _limitAge;

        public MinAge(int limitAge)
        {
            this._limitAge = limitAge;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {

            DateTime birthDay = DateTime.Parse(value.ToString());
            DateTime today = DateTime.Today;
            int age = today.Year - birthDay.Year;
            if (birthDay > today.AddYears(-age))
            {
                age--;
            }
            if (age < _limitAge)
            {
                var result = new ValidationResult("You need to be at least 18 years old in order to sign up!");
                return result;
            }

            return null;
        }

    }
}
