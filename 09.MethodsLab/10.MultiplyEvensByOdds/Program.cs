namespace _10.MultiplyEvensByOdds
{
    public class Program
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());

            Console.WriteLine(GetMultipleOfEvenAndOdds(input));    
        }

        static int GetSumOfOddDigits(int input)
        {
            int oddSum = 0;
            int number = Math.Abs(input);
            while (number != 0)
            {
                int digit = number % 10;
                if (digit % 2 != 0)
                {
                    oddSum+= digit;
                }
                number /= 10;
            }
            return oddSum;
        }

        static int GetSumOfEvenDigits(int input)
        {
            int evenSum = 0;
            int number = Math.Abs(input);
            while (number != 0)
            {
                int digit = number % 10;
                if (digit % 2 == 0)
                {
                    evenSum += digit;
                }
                number /= 10;
            }
            return evenSum;
        }

        static int GetMultipleOfEvenAndOdds(int input)
        {
            int multipleOfNums = GetSumOfEvenDigits(input) * GetSumOfOddDigits(input);

            return multipleOfNums;
        }

    }
}