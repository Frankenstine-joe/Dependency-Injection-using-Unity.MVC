using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Dependency_Injection_using_Unity.Models;
using Dependency_Injection_using_Unity.Repositories;
using Dependency_Injection_using_Unity.Interfaces;

namespace Dependency_Injection_using_Unity.Controllers
{
    public class StudentsController : Controller
    {
        private IStudentRepository _studentRepository;

        public StudentsController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        // GET: Students
        public ActionResult Index()
        {
            List<Student> students = _studentRepository.GetAllStudents();
            return View(students);
        }

        public ActionResult Details(int? Id)
        {
            Student student = _studentRepository.GetOneStudent();
            return View(student);
        }

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        _studentRepository.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}
    }
}
