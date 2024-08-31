namespace _04.ReverseArrayofStrings
{
    internal class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split().ToArray();

            input = input.Reverse().ToArray();


            foreach (var item in input)
            {
                Console.Write(item + " ");
            }
        }
    }
}