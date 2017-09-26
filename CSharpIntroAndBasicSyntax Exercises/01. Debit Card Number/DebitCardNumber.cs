using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Debit_Card_Number
{
    class DebitCardNumber
    {
        static void Main(string[] args)
        {
            int fistdigit = int.Parse(Console.ReadLine());
            int secdigit = int.Parse(Console.ReadLine());
            int treedigit = int.Parse(Console.ReadLine());
            int forthdigit = int.Parse(Console.ReadLine());
            Console.WriteLine($"{fistdigit:d4} {secdigit:d4} {treedigit:d4} {forthdigit:d4}");
        }
    }
}
