using System;
using MediatR;
using StudentManagement.Application.Students.Dto;

namespace StudentManagement.Application.Students.Queries
{
    public class GetStudentByIdQuery:IRequest<StudentDto>
    {
       public int Id { get; set; }
    }
}
