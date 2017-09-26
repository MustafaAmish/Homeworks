using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.VaporStore
{
    class VaporStore
    {
        static void Main(string[] args)
        {
            double currentBalance = double.Parse(Console.ReadLine());
            bool check = true;
            double price = 0;
            while (check)
            {
                string product = Console.ReadLine();
                if (product== "OutFall 4")
                {

                    
                    if (currentBalance >= 39.99)
                    {
                        price += 39.99;
                        currentBalance -= 39.99;
                        Console.WriteLine("Bought {0}", product);
                        if (currentBalance == 0)
                        {
                            

                            Console.WriteLine("Out of money!");
                            check = false;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (product== "CS: OG")
                {
                    
                    if (currentBalance >= 15.99)
                    {
                        price += 15.99;
                        currentBalance -= 15.99;
                        Console.WriteLine("Bought {0}", product);
                        if (currentBalance == 0)
                        {
                            

                            Console.WriteLine("Out of money!");
                            check = false;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (product== "Zplinter Zell")
                {
                    if (currentBalance >= 19.99)
                    {
                        price += 19.99;
                        currentBalance -= 19.99;
                        Console.WriteLine("Bought {0}", product);
                        if (currentBalance == 0)
                        {
                            

                            Console.WriteLine("Out of money!");
                            check = false;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }


                }
                else if (product == "Honored 2" )
                {
                    if (currentBalance >= 59.99)
                    {
                        price += 59.99;
                        currentBalance -= 59.99;
                        Console.WriteLine("Bought {0}", product);
                        if (currentBalance == 0)
                        {
                            

                            Console.WriteLine("Out of money!");
                            check = false;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (product == "RoverWatch" )
                {
                    if (currentBalance >= 29.99)
                    {
                        price += 29.99;
                        currentBalance -= 29.99;
                        Console.WriteLine("Bought {0}", product);
                        if (currentBalance == 0)
                        {
                            
                            Console.WriteLine("Out of money!");
                            check = false;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (product == "RoverWatch Origins Edition" )
                {
                    if (currentBalance >= 39.99)
                    {
                        price += 39.99;
                        currentBalance -= 39.99;
                        Console.WriteLine("Bought {0}", product);
                        if (currentBalance == 0)
                        {
                           

                            Console.WriteLine("Out of money!");
                            check = false;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (product == "Game Time")
                {
                    Console.WriteLine("Total spent: ${0:f2}. Remaining: ${1:f2}", price, currentBalance);
                    check = false;
                }
                else 
                {
                    Console.WriteLine("Not Found");
                }
            }
        }
    }
}
