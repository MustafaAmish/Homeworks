using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.StringsAndObjects
{
    class StringsAndObjects
    {
        static void Main(string[] args)
        {
            string firstValue = Console.ReadLine();
            string secondValue = Console.ReadLine();
            object value = ($"{firstValue} {secondValue}");
            string third =(string) value;

            Console.WriteLine(third);
        }
    }
}
