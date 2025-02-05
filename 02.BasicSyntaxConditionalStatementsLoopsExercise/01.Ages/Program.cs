using System;

namespace _01.Ages
{
    internal class Program
    {
        static void Main()
        {
            int age = int.Parse(Console.ReadLine());

            string ages = "";

            if (age >= 0 && age < 3)
            {
                ages = "baby";
            }
            else if (age > 2 && age < 14)
            {
                ages = "child";
            }
            else if (age > 13 && age < 20)
            {
                ages = "teenager";
            }
            else if (age > 19 && age < 66)
            {
                ages = "adult";
            }
            else if (age > 65)
            {
                ages = "elder";
            }

            Console.WriteLine(ages);
        }
    }
}
