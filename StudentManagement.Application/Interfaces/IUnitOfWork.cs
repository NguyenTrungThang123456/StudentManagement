using System;
namespace StudentManagement.Application.Interfaces
{
    public interface IUnitOfWork
    {
        IStudentRepository Students { get; }
    }
}
