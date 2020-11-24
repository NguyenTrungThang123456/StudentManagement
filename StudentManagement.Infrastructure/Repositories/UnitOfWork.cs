using System;
using StudentManagement.Application.Interfaces;

namespace StudentManagement.Infrastructure.Repositories
{
    public class UnitOfWork :IUnitOfWork
    {
        public UnitOfWork(IStudentRepository studentRepository)
        {
            Students = studentRepository;
        }

        public IStudentRepository Students { get; }
    }
}
