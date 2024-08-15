using System;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;

namespace _07.VendingMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "";

            double sum = 0.0;
            while ((input = Console.ReadLine()) != "Start")
            {
                double inputCoin = double.Parse(input);

                if (inputCoin == 2)
                {
                    sum += 2;
                }
                else if (inputCoin == 1)
                {
                    sum += 1;
                }
                else if (inputCoin == 0.1)
                {
                    sum += 0.1;
                }
                else if (inputCoin == 0.2)
                {
                    sum += 0.2;
                }
                else if (inputCoin == 0.5)
                {
                    sum += 0.5;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {inputCoin}");
                }
            }

            while ((input = Console.ReadLine()) != "End")
            {
                if (input != "Nuts" && input != "Water" && input != "Crisps" && input != "Soda" && input != "Coke")
                {
                    Console.WriteLine("Invalid product");
                }
                if (input == "Coke")
                {
                    if (sum >= 1)
                    {
                        Console.WriteLine("Purchased coke");
                        sum -= 1;
                    }
                    else Console.WriteLine("Sorry, not enough money");
                    
                }

                else if (input == "Soda")
                {
                    if (sum >= 0.8)
                    {
                        sum -= 0.8;
                        Console.WriteLine("Purchased soda");
                    }
                    else Console.WriteLine("Sorry, not enough money");

                }

                else if (input == "Crisps" && sum >= 1.5)
                {
                    if (sum >= 1.5)
                    {
                        sum -= 1.5;
                        Console.WriteLine("Purchased crisps");
                    }
                    else Console.WriteLine("Sorry, not enough money");

                }

                else if (input == "Water" && sum >= 0.7)
                {
                    if (sum >= 0.7)
                    {
                        sum -= 0.7;
                        Console.WriteLine("Purchased water");
                    }
                    else Console.WriteLine("Sorry, not enough money");

                }

                else if (input == "Nuts" && sum >= 2)
                {
                    if (sum >= 2)
                    {
                        sum -= 2;
                        Console.WriteLine("Purchased nuts");
                    }
                    else Console.WriteLine("Sorry, not enough money");

                }
            
            }

            Console.WriteLine($"Change: {sum:F2}");
        }
    }
}
