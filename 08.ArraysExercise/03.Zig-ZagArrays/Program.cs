namespace _03.Zig_ZagArrays
{
    public class Program
    {
        static void Main()
        {
            int rows = int.Parse(Console.ReadLine());

            int[] firstArr = new int[rows];
            int[] secondArr = new int[rows];

            for (int i = 0; i < rows; i++)
            {
                int[] tokens = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                if (i % 2 == 0)
                {
                    firstArr[i] = tokens[0];
                    secondArr[i] = tokens[1];
                }
                else
                {
                    firstArr[i] = tokens[1];
                    secondArr[i] = tokens[0];
                }
            }

            Console.WriteLine(String.Join(" ", firstArr));
            Console.WriteLine(String.Join (" ", secondArr));
        }
    }
}