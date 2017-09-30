using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.TheaThePhotographer
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberPictures = int.Parse(Console.ReadLine());
            int filterTime = int.Parse(Console.ReadLine());
            double filterFactorPercentage = double.Parse(Console.ReadLine())/100;
            int filteredPicturesUploaded = int.Parse(Console.ReadLine());
            var goodPictures = Math.Ceiling(numberPictures * filterFactorPercentage );
            long timeSortALlPictures = numberPictures * (long)filterTime;
            long timeUpload =(long) goodPictures * (long) filteredPicturesUploaded ;
            long totatlTime = timeSortALlPictures + timeUpload;
            int day=0;
            int hr = 0;
            int minuts = 0;
            // while (totatlTime>59)
            // {
            //     minuts++;
            //     totatlTime -= 60;
            //     if (minuts>59)
            //     {
            //         minuts -= 60;
            //         hr++;
            //         if (hr>23)
            //         {
            //             hr -= 24;
            //             day++;
            //         }
            //     }
            // }
            // Console.WriteLine($"{Convert.ToString(day)}:{hr:d2}:{minuts:d2}:{totatlTime:d2}");

            Console.WriteLine(TimeSpan.FromSeconds(totatlTime).ToString(new string('d',1)+ @"\:hh\:mm\:ss"));

        }
    }
}
