using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.PrintPartOfASCIITable
{
    class PrintPartOfASCIITable
    {
        static void Main(string[] args)
        {
            int startingChar = int.Parse(Console.ReadLine());
            int lastChar = int.Parse(Console.ReadLine());
            for (int i = startingChar; i <= lastChar; i++)
            {
                Console.Write((char)i+" ");
            }
            Console.WriteLine();
        }
    }
}
