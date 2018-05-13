using Dependency_Injection_using_Unity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Injection_using_Unity.Interfaces
{
    public interface IStudentRepository
    {
        Student GetOneStudent();
        List<Student> GetAllStudents();
    }
}
