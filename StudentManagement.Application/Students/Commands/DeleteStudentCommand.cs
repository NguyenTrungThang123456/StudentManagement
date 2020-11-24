using System;
using MediatR;

namespace StudentManagement.Application.Students.Commands
{
    public class DeleteStudentCommand:IRequest<int>
    {
        public int Id { get; set; }
    }
}
