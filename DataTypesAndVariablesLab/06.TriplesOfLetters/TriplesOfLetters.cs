using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.TriplesOfLetters
{
    class TriplesOfLetters
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (char i = 'a'; i < 'a'+n; i++)
            {
                for (char c = 'a'; c < 'a' + n; c++)
                {
                    for (char g = 'a'; g < 'a' + n; g++)
                    {
                        Console.WriteLine($"{i}{c}{g}");
                    }
                }
            }
        }
    }
}
