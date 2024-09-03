
namespace _01.SignOfIntegerNumbers
{
    public class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            CheckNumber(number);
        }

        private static void CheckNumber(int number)
        {
            if (number == 0)
            {
                Console.WriteLine($"The number {number} is zero.");
            }

            else if (number > 0)
            {
                Console.WriteLine($"The number {number} is positive.");
            }

            else Console.WriteLine($"The number {number} is negative.");
        }
    }
}