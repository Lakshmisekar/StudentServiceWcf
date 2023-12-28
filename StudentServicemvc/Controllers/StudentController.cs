using StudentServicemvc.StudentServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentServicemvc.Controllers
{
    public class StudentController : Controller
    {
        private IStudentService studentService = new StudentServiceClient();




        public ActionResult Index()
        {
            var students = studentService.GetStudents();
            return View(students);
        }

        public ActionResult Details(int id)
        {
            var student = studentService.GetStudentById(id);
            return View(student);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Student student)
        {
            studentService.AddStudent(student);
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            var student = studentService.GetStudentById(id);
            return View(student);
        }

        [HttpPost]
        public ActionResult Edit(Student student)
        {
            studentService.UpdateStudent(student);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            var student = studentService.GetStudentById(id);
            return View(student);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            studentService.DeleteStudent(id);
            return RedirectToAction("Index");
        }
    }
}