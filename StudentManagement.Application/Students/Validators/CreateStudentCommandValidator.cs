using System;
using FluentValidation;
using StudentManagement.Application.Students.Commands;

namespace StudentManagement.Application.Students.Validators
{
    public class CreateStudentCommandValidator :AbstractValidator<CreateStudentCommand>
    {
        public CreateStudentCommandValidator()
        {
            RuleFor(std => std.Name).NotEmpty();
            RuleFor(std => std.Status).NotNull();
        }
    }
}
