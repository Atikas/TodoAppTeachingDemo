﻿using System.ComponentModel.DataAnnotations;

namespace TodoApp.API.Validators;

public class LessOrEqualToTodayAttribute : ValidationAttribute
{
    protected override ValidationResult IsValid(object? value, ValidationContext validationContext)
    {
        if (value == null || string.IsNullOrEmpty(value.ToString()))
        {
            return ValidationResult.Success!;
        }

        var date = DateTime.Parse(value!.ToString());

        if (date > DateTime.Today)
        {
            return new ValidationResult("Date must be less than or equal to today.");
        }

        return ValidationResult.Success!;
    }
    
}

