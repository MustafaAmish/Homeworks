using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Elevator
{
    class Elevator
    {
        static void Main(string[] args)
        {
            int ppl = int.Parse(Console.ReadLine());
            double capacityPpl = double.Parse(Console.ReadLine());
            Console.WriteLine("{0}",Math.Ceiling(ppl/capacityPpl));
        }
    }
}
