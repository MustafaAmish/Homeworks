using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.FastPrimeChecker
{
    class FastPrimeChecker
    {
        static void Main(string[] args)
        {
            int rang = int.Parse(Console.ReadLine());
            for (int number = 2; number <= rang; number++)
            {
                bool primeChecker= true;
                for (int divine = 2; divine <= Math.Sqrt(number); divine++)
                {
                    if (number % divine == 0)
                    {
                        primeChecker = false;
                        break;
                    }
                }
                Console.WriteLine($"{number} -> {primeChecker}");
            }

        }
    }
}
