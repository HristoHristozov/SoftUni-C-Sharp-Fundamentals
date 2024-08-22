namespace _02.FromLefttoTheRight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < inputLines; i++)
            {
                string numbers = Console.ReadLine();
                char delimeter = ' ';
                string[] splitNumbers = numbers.Split(delimeter);

                long leftNum = long.Parse(splitNumbers[0]);
                long rightNum = long.Parse(splitNumbers[1]);

                long biggerNum = leftNum;
                if (leftNum < rightNum)
                {
                    biggerNum = rightNum;
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