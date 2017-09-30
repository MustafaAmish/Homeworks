using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.ComparingFloats
{
    class ComparingFloats
    {
        static void Main(string[] args)
        {
            double firstDigit = double.Parse(Console.ReadLine());
            double secondtDigit = double.Parse(Console.ReadLine());
            double eps = 0.000001;
            if (Math.Abs(firstDigit-secondtDigit)<eps)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}
