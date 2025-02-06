namespace _12.RefactorSpecialNumbers
{
    internal class Program
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());

            for (int i = 1; i <= input; i++)
            {
                bool isSpecial = false;
                int sum = 0;
                int number = i;
                
                while (number != 0)
                {
                    int lastDigit = number % 10;
                    number /= 10;
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