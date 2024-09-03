namespace _03.Zig_ZagArrays
{
    public class Program
    {
        static void Main()
        {
            int lines = int.Parse(Console.ReadLine());

            int[] firstArr = new int[lines];
            int[] secondArr = new int[lines];

            for (int i = 0; i < lines; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

                if (i % 2 == 0)
                {
                    firstArr[i] = input[0];
                    secondArr[i] = input[1];
                }
                else
                {
                    firstArr[i] = input[1];
                    secondArr[i] = input[0];
                }
            }

            Console.WriteLine(String.Join(" ", firstArr));
            Console.WriteLine(String.Join(" ", secondArr));
        }
    }
}