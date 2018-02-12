using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wcgServiceConsumer.ServiceReference1;

namespace wcgServiceConsumer
{
    public class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();

            using (var client = new ServiceReference1.Service1Client())
            {
                Console.WriteLine(client.AddStudent(s1));
            }
            Console.ReadLine();

            
        }
    }
}
