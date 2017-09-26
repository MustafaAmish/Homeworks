using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                int multiplication = num * i;
                Console.WriteLine("{0} X {1} = {2}",num,i,multiplication);
            }
        }
    }
}
