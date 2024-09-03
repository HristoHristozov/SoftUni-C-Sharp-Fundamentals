namespace _04.ArrayRotation
{
    public class Program
    {
        static void Main()
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rotations = int.Parse(Console.ReadLine());

            for (int i = 0; i < rotations; i++)
            {
                var temp = input[0];

                for (int j = 0; j < input.Length - 1; j++)
                {
                    input[j] = input[j + 1];
                }

                input[input.Length - 1] = temp;
            }

            Console.WriteLine(String.Join(' ', input));
        }
    }
}