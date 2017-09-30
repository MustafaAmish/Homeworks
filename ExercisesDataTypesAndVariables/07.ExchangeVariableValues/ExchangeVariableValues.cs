﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.ExchangeVariableValues
{
    class ExchangeVariableValues
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            Console.WriteLine($"Before:\n" +
               $"a = {a}\n" +
               $"b = {b}");
            int c = a;
            a = b;
            b = c;
            Console.WriteLine($"After:\n" +
               $"a = {a}\n" +
               $"b = {b}");
        }
    }
}
