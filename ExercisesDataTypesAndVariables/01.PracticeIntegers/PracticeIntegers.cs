using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.PracticeIntegers
{
    class PracticeIntegers
    {
        static void Main(string[] args)
        {
            sbyte num = -100;
            byte num1 = 128;
            short num2 = -3540;
            ushort num3 = 64876;
            uint num4= 2147483648;
            int num5 = -1141583228;
            long num6= -1223372036854775808;
            Console.WriteLine($"{num}\n{num1}\n{num2}\n" +
                $"{num3}\n{num4}\n{num5}\n{num6}");
        }
    }
}
