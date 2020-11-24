using System;
using AutoMapper;
using StudentManagement.Application.Students.Commands;
using StudentManagement.Application.Students.Dto;
using StudentManagement.Core.Entities;

namespace StudentManagement.Application.Students.MappingProfiles
{
    public class StudentMappingProfile:Profile
    {
        public StudentMappingProfile()
        {
            CreateMap<CreateStudentCommand, Student>();
            CreateMap<UpdateStudentCommand, Student>();
            CreateMap<Student, StudentDto>();
        }
    }
}
