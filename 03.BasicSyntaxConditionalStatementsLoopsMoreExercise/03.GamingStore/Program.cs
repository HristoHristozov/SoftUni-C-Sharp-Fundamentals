using System.Runtime.CompilerServices;

namespace _03.GamingStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double initialMoney = double.Parse(Console.ReadLine());
            double balance = initialMoney;

            string input = "";
            double totalSpent = 0.0;
            while ((input = Console.ReadLine()) != "Game Time")
            {
               

                if (input == "OutFall 4")
                {
                    if (balance >= 39.99)
                    {
                        balance -= 39.99;
                        totalSpent += 39.99;
                        Console.WriteLine("Bought OutFall 4");
                    }
                    else 
                    {
                        Console.WriteLine("Too Expensive");
                    }

                }

                else if (input == "CS: OG")
                {
                    if (balance >= 15.99)
                    {
                        balance -= 15.99;
                        totalSpent += 15.99;
                        Console.WriteLine("Bought CS: OG");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }

                }

                else if (input == "Zplinter Zell")
                {
                    if (balance >= 19.99)
                    {
                        balance -= 19.99;
                        totalSpent += 19.99;
                        Console.WriteLine("Bought Zplinter Zell");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }

                }

                else if (input == "Honored 2")
                {
                    if (balance >= 59.99)
                    {
                        balance -= 59.99;
                        totalSpent += 59.99;
                        Console.WriteLine("Bought Honored 2");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }

                }

                else if (input == "RoverWatch")
                {
                    if (balance >= 29.99)
                    {
                        balance -= 29.99;
                        totalSpent += 29.99;
                        Console.WriteLine("Bought RoverWatch");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }

                }

                else if (input == "RoverWatch Origins Edition")
                {
                    if (balance >= 39.99)
                    {
                        balance -= 39.99;
                        totalSpent += 39.99;
                        Console.WriteLine("Bought RoverWatch Origins Edition");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }

                }

                else 
                {
                    Console.WriteLine("Not Found");
                }
            }

            if (initialMoney - totalSpent > 0)
            {
                Console.WriteLine($"Total spent: ${totalSpent:F2}. Remaining: ${balance:F2}");
            }

            else 
            {
                Console.WriteLine("Out of money!");
            }
        }
    }
}