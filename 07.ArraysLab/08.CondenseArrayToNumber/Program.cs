namespace _08.CondenseArrayToNumber
{
    internal class Program
    {
        static void Main()
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            if (input.Length == 1)
            {
                Console.WriteLine(input[0]);
                return;
            }

            while (input.Length > 1)
            {
                int[] condensed = new int[input.Length - 1];

                for (int i = 0; i < condensed.Length; i++)
                {
                    condensed[i] = input[i] + input[i + 1];
                }
                input = condensed;
            }

            Console.WriteLine(String.Join(' ',input));
        }
    }
}