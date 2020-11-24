using System;
using StudentManagement.Core.Entities.Enums;

namespace StudentManagement.Core.Entities
{
    public class Student
    { 
        public int Id { get; set; }

        public string Name { get; set; }

        public StudentStatus Status { get; set;}

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

    }
}
