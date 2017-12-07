using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCTest1.Models
{
    public class RegisterViewModelValidator : AbstractValidator<RegisterViewModel>
    {
        public RegisterViewModelValidator()
        {
            RuleFor(x => x.Email)
                .NotNull().WithMessage("My! Email can not be empty");

            RuleFor(x => x.Password)
                .NotNull()
                .WithMessage("My! Password can not be empty");

            RuleFor(x => x.Password)
                .Length(6, 100).WithMessage("My! Password is between 6 and 100 letters");

            RuleFor(x => x.ConfirmPassword)
                .Equal(x => x.Password).WithMessage("My! confirm password should be the same");
        }
    }
}