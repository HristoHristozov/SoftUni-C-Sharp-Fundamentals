namespace _06.EvenAndOddSubtraction
{
    internal class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int evenNums = 0;
            int oddNums = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNum = numbers[i];

                if (currentNum % 2 == 0)
                {
                    evenNums += currentNum;
                }
                else oddNums += currentNum;

            }

            Console.WriteLine(evenNums - oddNums);
        }
    }
}