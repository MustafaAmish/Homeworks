using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.IntegerToHexAndBinary
{
    class IntegerToHexAndBinary
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            var num1 = Convert.ToString(num, 16);
            var num2 = Convert.ToString(num, 2);

            Console.WriteLine(num1.ToUpper());
            Console.WriteLine(num2.ToUpper());
        }
    }
}
