using System;

namespace _05.Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userName = Console.ReadLine();

            char[] str = userName.ToCharArray();
            Array.Reverse(str);

            string password = new string(str);

            int blockedCounter = 0;
            while (true)
            {

                string input = Console.ReadLine();            


                if (input != password)
                {
                    blockedCounter++;
                    if (blockedCounter < 4)
                    {
                        Console.WriteLine("Incorrect password. Try again.");
                    }
                    
                }
                if (blockedCounter >= 4)
                {
                    Console.WriteLine($"User {userName} blocked!");
                    break;
                }

                else if (input == password)
                {
                    Console.WriteLine($"User {userName} logged in.");
                    break;
                }
            }



        }
    }
}
