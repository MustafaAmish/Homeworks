using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.VariableInHexFormat
{
    class VariableInHexFormat
    {
        static void Main(string[] args)
        {
            string hexFormat = Console.ReadLine();
            int num = Convert.ToInt32(hexFormat,16);
            Console.WriteLine(num);

        }
    }
}
