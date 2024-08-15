namespace _01.SortNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

            int[] numbers = {firstNum,secondNum,thirdNum };
            Array.Sort(numbers);
            Array.Reverse(numbers);

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
            
        }
    }
}