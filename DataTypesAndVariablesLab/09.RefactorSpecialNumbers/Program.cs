using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.RefactorSpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int nNumber = int.Parse(Console.ReadLine());
            for (int i = 1; i <= nNumber; i++)
            {
                int courentNumber = i;
                int sum = 0;
                while (courentNumber>0)
                {
                    sum += courentNumber % 10;
                    courentNumber = courentNumber / 10;
                }
                bool checkSpecialNumbers = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine("{0} -> {1}",i,checkSpecialNumbers);
            }
        }
    }
}
