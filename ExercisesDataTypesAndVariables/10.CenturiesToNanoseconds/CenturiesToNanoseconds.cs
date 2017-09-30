using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _10.CenturiesToNanoseconds
{
    class CenturiesToNanoseconds
    {
        static void Main(string[] args)
        {
            byte centuries = byte.Parse(Console.ReadLine());
            int years = centuries * 100;
            int days = (int)(years * 365.2422);
            int hr = days * 24;
            long min = hr * 60;
            long sec = min * 60;
            long milisec = sec * 1000;
            ulong microsec =(ulong) milisec * 1000;
            decimal nanosec =(decimal) microsec * 1000m;



            Console.WriteLine("{0} centuries = {1} years = {2} days = {3} hours = {4} minutes = {5}" +
                " seconds = {6} milliseconds = {7} microseconds = {8} nanoseconds"
                , centuries, years, days, hr, min,sec,milisec,microsec,nanosec);

        }
    }
}
