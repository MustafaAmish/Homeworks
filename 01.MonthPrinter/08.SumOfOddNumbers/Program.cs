using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.SumOfOddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int sumNum = 0;
            for (int i = 1; i <= num*2; i+=2)
            {
                
                sumNum += i;
                Console.WriteLine(i);
            }
            Console.WriteLine("Sum: "+sumNum);
        }
    }
}
