using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.VowelOrDigit
{
    class VowelOrDigit
    {
        static void Main(string[] args)
        {
            char givenSymbol = char.Parse(Console.ReadLine());
            if (givenSymbol == 'a' || givenSymbol == 'e' || givenSymbol == 'o' ||
                givenSymbol == 'u' || givenSymbol == 'i'||givenSymbol=='y')
            {
                Console.WriteLine("vowel");
            }
            else if (char.IsDigit(givenSymbol))
            {
                Console.WriteLine("digit");
            }
            else
            {
                Console.WriteLine("other");
            }
        }
    }
}
