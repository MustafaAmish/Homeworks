using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.BooleanVariable
{
    class BooleanVariable
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            bool nama = Convert.ToBoolean(name);
            if (nama)
            {
                Console.WriteLine("Yes");

            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
