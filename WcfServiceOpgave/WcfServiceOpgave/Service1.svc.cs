using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfServiceOpgave
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public void AddStudent(Student student)
        {
            studentList.Add(student);
        }

        public void FindStudents(int ssn)
        {
            foreach (var student in studentList)
            {
                if (ssn == student.SSN)
                {
                    Console.WriteLine(student);
                }
            }
        }

        public void GetAllStudents()
        {
            foreach (var student in studentList)
            {
                Console.WriteLine(student);
            }
        }

        public void RemoveStudent(Student student)
        {
            studentList.Remove(student);
        }

        public void EditStudent(string name, int age, Student student)
        {
            student.Name = name;
            student.Age = age;
        }

        List<Student> studentList = new List<Student>();

    }
}

