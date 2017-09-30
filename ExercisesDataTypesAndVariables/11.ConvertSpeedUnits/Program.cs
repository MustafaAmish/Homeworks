using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.ConvertSpeedUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            int distanceInMeters= int.Parse(Console.ReadLine());
            int hr = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            float metersSec = (distanceInMeters / ((((hr * 60) + min )*60f + second)));
            float kmPerHr =( metersSec * 3600) / 1000f;
            float milesPerHr = kmPerHr / 1.609F;
            Console.WriteLine("{0:}",metersSec);
            Console.WriteLine("{0}", kmPerHr);
            Console.WriteLine("{0}",milesPerHr);
            
        }
    }
}
