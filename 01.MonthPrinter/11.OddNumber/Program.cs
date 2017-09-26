using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.OddNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            bool chek = true;
            while (chek == true)
            {
                int num = int.Parse(Console.ReadLine());
                if (num % 2 == 1)
                {
                    Console.WriteLine("The number is: {0}", Math.Abs(num));
                    chek = false;
                }
                Console.WriteLine("Please write an odd number.");


            }
        }
    }
}
