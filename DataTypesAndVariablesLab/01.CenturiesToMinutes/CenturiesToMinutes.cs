using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.CenturiesToMinutes
{
    class CenturiesToMinutes
    {
        static void Main(string[] args)
        {
            byte centuries = byte.Parse(Console.ReadLine());
            int years = centuries * 100;
            int days = (int)(years * 365.2422);
            int hr = days * 24;
            int min = hr * 60;
            Console.WriteLine("{0} centuries = {1} years = {2} days = {3} hours = {4} minutes"
                ,centuries,years,days,hr,min);
        }
    }
}
