using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace StudentService
{
    [ServiceContract]
    public interface IStudentService
    {
        [OperationContract]
        List<Student> GetStudents();

        [OperationContract]
        Student GetStudentById(int studentId);

        [OperationContract]
        void AddStudent(Student student);
        [OperationContract]
        void UpdateStudent(Student student);

        [OperationContract]
        void DeleteStudent(int studentId);
    }
}
