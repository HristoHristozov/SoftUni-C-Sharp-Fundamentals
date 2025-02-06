namespace _05.SpecialNumbers
{
    internal class Program
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());

            for (int i = 1; i <= input; i++)
            {
                bool isSpecial = false;
                int currentNumber = i;
                int sum = 0;
                while (currentNumber != 0)
                {
                    int lastDigit = currentNumber % 10;
                    currentNumber /= 10;
                    sum += lastDigit;
                }

                if (sum == 5 || sum == 7 || sum == 11)
                {
                    isSpecial = true;
                }
                Console.WriteLine($"{i} -> {isSpecial}");
            }

        }
    }
}