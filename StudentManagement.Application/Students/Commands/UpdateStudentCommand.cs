using System;
using MediatR;
using StudentManagement.Core.Entities.Enums;

namespace StudentManagement.Application.Students.Commands
{
    public class UpdateStudentCommand :IRequest<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public StudentStatus Status { get; set; }
    }
}
