namespace _06.EvenAndOddSubtraction
{
    internal class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int evenNums = 0;
            int oddNums = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    evenNums += numbers[i];
                }
                else oddNums += numbers[i];
            }

            Console.WriteLine(evenNums - oddNums);
        }
    }
}