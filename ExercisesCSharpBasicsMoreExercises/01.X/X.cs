using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.X
{
    class X
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int row = 0;
            for (int i = 1; i <= (count+1)/2; i++)
            {
                row+=2;
                if (i==(count+1)/2)
                {
                    Console.WriteLine("{0}x", new string(' ', i - 1));
                }
                else
                {
                    Console.WriteLine("{0}x{1}x", new string(' ',i-1), new string(' ',count- row));
                }
            }
            for (int i = 1; i <= (count - 1) / 2; i++)
            {
                row -= 2;
                Console.WriteLine("{0}x{1}x", new string(' ', (count-1)/2-i), new string(' ', count - row));

            }

        }
    }
}
