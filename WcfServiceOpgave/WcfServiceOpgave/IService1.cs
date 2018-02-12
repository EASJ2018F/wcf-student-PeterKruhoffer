using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfServiceOpgave
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        void AddStudent(Student student);

        [OperationContract]
        void FindStudents(int ssn);

        [OperationContract]
        void GetAllStudents();

        [OperationContract]
        void RemoveStudent(Student student);

        [OperationContract]
        void EditStudent(string name, int age, Student student);

    }


   
}
