using System;

namespace _03.Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfPeopleOnVacation = int.Parse(Console.ReadLine());
            string typeOfGroup = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();

            decimal totalPrice = 0.0m;

            if (typeOfGroup == "Students")
            {
                if (dayOfWeek == "Friday")
                {
                    totalPrice = 8.45m * countOfPeopleOnVacation;
                }

                else if (dayOfWeek == "Saturday")
                {
                    totalPrice = 9.80m * countOfPeopleOnVacation;
                }

                else if (dayOfWeek == "Sunday")
                {
                    totalPrice = 10.46m * countOfPeopleOnVacation;
                }

                if (countOfPeopleOnVacation >= 30)
                {
                    totalPrice -= totalPrice * 0.15m;
                }
            }

            else if (typeOfGroup == "Business")
            {

                if (countOfPeopleOnVacation >= 100)
                {
                    countOfPeopleOnVacation -= 10;
                }
                if (dayOfWeek == "Friday")
                {
                    totalPrice = 10.90m * countOfPeopleOnVacation;
                }

                else if (dayOfWeek == "Saturday")
                {
                    totalPrice = 15.60m * countOfPeopleOnVacation;
                }

                else if (dayOfWeek == "Sunday")
                {
                    totalPrice = 16 * countOfPeopleOnVacation;
                }


            }

            else if (typeOfGroup == "Regular")
            {
                if (dayOfWeek == "Friday")
                {
                    totalPrice = 15 * countOfPeopleOnVacation;
                }

                else if (dayOfWeek == "Saturday")
                {
                    totalPrice = 20 * countOfPeopleOnVacation;
                }

                else if (dayOfWeek == "Sunday")
                {
                    totalPrice = 22.50m * countOfPeopleOnVacation;
                }

                if (countOfPeopleOnVacation >= 10 && countOfPeopleOnVacation <= 20)
                {
                    totalPrice -= totalPrice * 0.05m;
                }
            }

            Console.WriteLine($"Total price: {totalPrice:F2}");
        }
    }
}
