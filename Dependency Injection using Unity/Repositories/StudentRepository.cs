using Dependency_Injection_using_Unity.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Dependency_Injection_using_Unity.Models;

namespace Dependency_Injection_using_Unity.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        public List<Student> GetAllStudents()
        {
            return new List<Student>();
        }

        public Student GetOneStudent()
        {
            return new Student
            {
                Address = "Whatever",
                Id = 10,
                Name = "John Doe",
                Phone = "101010"
            };
        }
    }
}