namespace _08.FactorialDivision
{
    internal class Program
    {
        static void Main()
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            decimal firstFactorial = CalculateFactorial(firstNum);
            decimal secondFactorial = CalculateFactorial(secondNum);

            Console.WriteLine($"{firstFactorial/secondFactorial:F2}");
        }

        static decimal CalculateFactorial(int a)
        {
            decimal result = 1.0m;

            for (int i = 1; i <= a; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
