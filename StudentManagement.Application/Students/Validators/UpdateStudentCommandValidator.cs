using System;
using FluentValidation;
using StudentManagement.Application.Students.Commands;

namespace StudentManagement.Application.Students.Validators
{
    public class UpdateStudentCommandValidator:AbstractValidator<UpdateStudentCommand>
    {
        public UpdateStudentCommandValidator()
        {
            RuleFor(std => std.Name).NotEmpty();
            RuleFor(std => std.Status).NotNull();
        }
    }
}
