using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.SpecialNumbers
{
    class SpecialNumbers
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= num; i++)
            {
                int sum = 0;
                int count = i;
                while (count>0)
                {
                    sum += count %10;
                    count = count / 10;
                }
                if (sum==5||sum==7||sum==11)
                {
                    Console.WriteLine($"{i} -> True");
                }
                else
                {
                    Console.WriteLine($"{i} -> False");
                }
            }
        }
    }
}
