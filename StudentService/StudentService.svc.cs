using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace StudentService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class StudentService : IStudentService
    {
        private StudentContext db = new StudentContext();

        public List<Student> GetStudents()
        {
            return db.Students.ToList();
        }

        public Student GetStudentById(int studentId)
        {
            return db.Students.FirstOrDefault(s => s.StudentId == studentId);
        }

        public void AddStudent(Student student)
        {
            db.Students.Add(student);
            db.SaveChanges();
        }

        public void UpdateStudent(Student student)
        {
            var existingStudent = db.Students.Find(student.StudentId);
            if (existingStudent != null)
            {
                existingStudent.FirstName = student.FirstName;
                existingStudent.LastName = student.LastName;
                existingStudent.Age = student.Age;
                db.SaveChanges();
            }
            else
            {
                throw new InvalidOperationException("Student not found");
            }
        }

        public void DeleteStudent(int studentId)
        {
            var existingStudent = db.Students.Find(studentId);
            if (existingStudent != null)
            {
                db.Students.Remove(existingStudent);
                db.SaveChanges();
            }
            else
            {
                throw new InvalidOperationException("Student not found");
            }
        }

      
    }

}