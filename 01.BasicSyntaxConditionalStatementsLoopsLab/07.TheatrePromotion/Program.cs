using System;

namespace _07.TheatrePromotion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var typeOfDay = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());

            var price = 0.0;

            if (age >= 0 && age <= 18)
            {
                if (typeOfDay == "Weekday")
                {
                    price = 12;
                }
                else if (typeOfDay == "Weekend")
                {
                    price = 15;
                }
                else if (typeOfDay == "Holiday")
                {
                    price = 5;
                }
            }

            else if (age > 18 && age <= 64)
            {
                if (typeOfDay == "Weekday")
                {
                    price = 18;
                }
                else if (typeOfDay == "Weekend")
                {
                    price = 20;
                }
                else if (typeOfDay == "Holiday")
                {
                    price = 12;
                }
            }

            else if (age > 64 && age <= 122)
            {
                if (typeOfDay == "Weekday")
                {
                    price = 12;
                }
                else if (typeOfDay == "Weekend")
                {
                    price = 15;
                }
                else if (typeOfDay == "Holiday")
                {
                    price = 10;
                }
            }

            if (age >= 0 && age <= 122)
            {
                Console.WriteLine($"{price}$");
            }


            else 
            {
                Console.WriteLine("Error!");
            }
        }
    }
}
