using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.RefactorVolumeOfPyramid
{
    class RefactorVolumeOfPyramid
    {
        static void Main(string[] args)
        {
            //double dul, sh, V = 0;
            double length = double.Parse(Console.ReadLine());
           double width = double.Parse(Console.ReadLine());
           double heigth = double.Parse(Console.ReadLine());
            double volume = (length * width * heigth)/3 ;
            Console.WriteLine("Length: Width: Height: Pyramid Volume: {0:F2}", volume);

        }
    }
}
