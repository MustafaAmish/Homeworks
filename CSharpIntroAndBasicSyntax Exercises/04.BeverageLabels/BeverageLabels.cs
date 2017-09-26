using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.BeverageLabels
{
    class BeverageLabels
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            double volume = double.Parse(Console.ReadLine());
            double energy = double.Parse(Console.ReadLine());
            double sugar = double.Parse(Console.ReadLine());
            Console.WriteLine("{0}ml {1}:\n{2}kcal, {3}g sugars",
                volume,product,(volume*energy)/100, (volume * sugar) / 100);
        }
    }
}
