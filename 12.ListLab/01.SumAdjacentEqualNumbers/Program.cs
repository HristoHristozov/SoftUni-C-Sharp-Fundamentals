namespace _01.SumAdjacentEqualNumbers
{
    internal class Program
    {
        static void Main()
        {
            List<double> input = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToList();

            for (int i = 0; i < input.Count; i++)
            {
                if (i + 1 > input.Count - 1)
                    break;

                if (input[i] == input[i + 1])
                {
                    input[i] += input[i + 1];
                    input.RemoveAt(i + 1);
                    i = -1;
                }
            }

            Console.WriteLine(string.Join(" ",input));
        }
    }
}
