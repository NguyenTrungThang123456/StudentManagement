using System;
using System.Collections.Generic;
using MediatR;
using StudentManagement.Application.Students.Dto;

namespace StudentManagement.Application.Students.Queries
{
    public class GetAllStudentsQuery:IRequest<List<StudentDto>>
    {
        
    }
}
