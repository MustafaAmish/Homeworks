using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.CircleAreaPrecision2
{
    class CircleAreaPrecision2
    {
        static void Main(string[] args)
        {
            double radius = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:F12}",Math.PI*radius*radius);
        }
    }
}
