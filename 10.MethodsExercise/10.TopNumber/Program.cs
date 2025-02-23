namespace _10.TopNumber
{
    internal class Program
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());

            for (int i = 1; i <= input; i++)
            {
                if (IsSumDivisibleBy8(i) && HasAtLeastOneOddDigit(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        static bool IsSumDivisibleBy8(int number)
        {
            int sum = 0;
            int temp = number;

            while (temp > 0)
            {
                sum += temp % 10;
                temp /= 10;
            }
            return sum % 8 == 0;
        }

        static bool HasAtLeastOneOddDigit(int number)
        {
            return number.ToString().Any(c => c % 2 != 0);
        }
    }
}
