using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.PhotoGallery
{
    class Program
    {
        static void Main(string[] args)
        {
            int numFoto = int.Parse(Console.ReadLine());
            int dd = int.Parse(Console.ReadLine());
            int mm = int.Parse(Console.ReadLine());
            int yyyy = int.Parse(Console.ReadLine());
            int hr = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());
            double imageSize = double.Parse(Console.ReadLine());
            int resolutionWidth= int.Parse(Console.ReadLine());
            int resolitionHeight = int.Parse(Console.ReadLine());
            string bitesSize = string.Empty;
            string orientation = string.Empty;
            if (imageSize<1000)
            {
                bitesSize = "B";
            }
            else if (imageSize<1000000)
            {
                bitesSize = "KB";
                imageSize /= 1000;
            }
            else if (imageSize >= 1000000)
            {
                bitesSize = "MB";
                imageSize /= 1000000.0;
            }
            if (resolitionHeight==resolutionWidth)
            {
                orientation = "square";
            }
            else if (resolitionHeight>resolutionWidth)
            {
                orientation = "portrait";
            }
            else
            {
                orientation = "landscape";
            }
            Console.WriteLine("Name: DSC_{0:d4}.jpg\n" +
                "Date Taken: {1:d2}/{2:d2}/{3} {4:d2}:{5:d2}\n" +
                "Size: {6}{7}\n" +
                "Resolution: {8}x{9} ({10})"
                , numFoto,dd,mm,yyyy,hr,min,imageSize,bitesSize,resolutionWidth,resolitionHeight,orientation);


        }
    }
}
