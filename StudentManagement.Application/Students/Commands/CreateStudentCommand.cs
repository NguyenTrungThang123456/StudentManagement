using System;
using MediatR;
using StudentManagement.Core.Entities.Enums;

namespace StudentManagement.Application.Students.Commands
{
    public class CreateStudentCommand:IRequest<int>
    {
        public string Name { get; set; }
        public StudentStatus Status { get; set; }
    }
}
