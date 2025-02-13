namespace _02.FromLefttoTheRight
{
    internal class Program
    {
        static void Main()
        {
            int inputLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < inputLines; i++)
            {
                string[] input = Console.ReadLine().Split(' ');

                long firstToken = long.Parse(input[0]);
                long secondToken = long.Parse(input[1]);

                long biggerNum = firstToken;
                if (firstToken < secondToken)
                {
                    biggerNum = secondToken;
                }

                long sumOfDigits = 0;
                while (biggerNum != 0)
                {
                    sumOfDigits += biggerNum % 10;
                    biggerNum /= 10;
                }

                Console.WriteLine($"{Math.Abs(sumOfDigits)}");
            }
        }
    }
}