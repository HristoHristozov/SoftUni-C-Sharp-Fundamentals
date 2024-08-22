namespace _12.RefactorSpecialNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int sum = 0;
            int number = 0;
            bool isSpecial = false;
            for (int i = 1; i <= input; i++)
            {
                number = i;
                while (i > 0)
                {
                    int lastDigit = number % 10;
                    number /= 10;
                    sum += lastDigit;
                }
                isSpecial = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine("{0} -> {1}", number, isSpecial);
                sum = 0;
                i = number;

            }
        }
    }
}