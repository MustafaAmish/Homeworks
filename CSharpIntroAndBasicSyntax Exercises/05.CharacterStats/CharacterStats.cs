using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.CharacterStats
{
    class CharacterStats
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int currentHealth = int.Parse(Console.ReadLine());
            int maximumHealth = int.Parse(Console.ReadLine());
            int currentenergy = int.Parse(Console.ReadLine());
            int maximumenergy = int.Parse(Console.ReadLine());
            Console.WriteLine("Name: {0}\n" +
                "Health: |{1}{2}|\n" +
                "Energy: |{3}{4}|",name,new string('|',currentHealth),new string('.',maximumHealth-currentHealth),
               new string ('|',currentenergy),new string('.',maximumenergy-currentenergy) );
        }
    }
}
