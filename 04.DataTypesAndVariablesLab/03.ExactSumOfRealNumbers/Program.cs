namespace _03.ExactSumOfRealNumbers
{
    internal class Program
    {
        static void Main()
        {
            int inputCount = int.Parse(Console.ReadLine());

            decimal sum = 0;

            for (int i = 0; i < inputCount; i++)
            {
                decimal currentNum = decimal.Parse(Console.ReadLine());
                sum += currentNum;
            }

            Console.WriteLine(sum);

        }
    }
}