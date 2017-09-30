using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.EmployeeData
{
    class EmployeeData
    {
        static void Main(string[] args)
        {
            string firstName = "Amanda";
            string lastName = "Jonson";
            short age = 27;
            char gender = 'f';
            long personalID = 8306112507;
            int employeeNumber = 27563571;
            Console.WriteLine($"First name: {firstName}\n "+
                            $"Last name: {lastName}\n"+
                              $"Age: {age}\n"+
                              $"Gender: { gender}\n"+
                              $"Personal ID: { personalID}\n"+
                              $"Unique Employee number: { employeeNumber}");

        }
    }
}
