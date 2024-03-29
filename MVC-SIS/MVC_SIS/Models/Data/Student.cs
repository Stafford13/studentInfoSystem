﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Exercises.Models.Data
{
    public class Student : IValidatableObject
    {
        //[Required(ErrorMessage ="Please enter a student Id")]
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal GPA { get; set; }
        public Address Address { get; set; }
        public Major Major { get; set; }
        public List<Course> Courses { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            List<ValidationResult> errors = new List<ValidationResult>();
            if (string.IsNullOrEmpty(FirstName))
            {
                errors.Add(new ValidationResult("Please enter your name", new[] { "FirstName" }));
            }

            if (string.IsNullOrEmpty(LastName))
            {
                errors.Add(new ValidationResult("Please enter your name", new[] { "LastName" }));
            }

            if(GPA < 0 || GPA > 4)
            {
                errors.Add(new ValidationResult("Please entere a valid GPA between 0 and 4", new[] { "GPA" }));
            }



            return errors;
        }
    }
}