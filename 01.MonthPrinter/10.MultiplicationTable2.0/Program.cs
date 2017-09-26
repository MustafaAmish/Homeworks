using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.MultiplicationTable2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int count = int.Parse(Console.ReadLine());
            int multi = 0;
            if (count <= 10)
            {
                for (int i = count; i <= 10; i++)
                {
                    multi = i * num;
                    Console.WriteLine("{0} X {1} = {2}", num, i, multi);
                }
               
            }
            else
            {
                multi = count * num;
                Console.WriteLine("{0} X {1} = {2}", num, count, multi);


            }
        }
    }
}
