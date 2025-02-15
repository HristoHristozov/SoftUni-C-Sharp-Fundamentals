namespace _05.TopIntegers
{
    public class Program
    {
        static void Main()
        {
            int[] inputArray = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < inputArray.Length; i++)
            {
                bool isBigger = true;

                for (int j = i + 1; j < inputArray.Length; j++)
                {
                    if (inputArray[i] <= inputArray[j])
                    {
                        isBigger = false;
                    }
                }

                if (isBigger)
                {
                    Console.Write(inputArray[i] + " ");
                }
            }
        }
    }
}