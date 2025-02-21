namespace _07.MaxSequenceOfEqualElements
{
    public class Program
    {
        static void Main()
        {
            int[] inputArray = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int maxLength = 0;
            int bestStartIndex = 0;
            int currentLength = 1;

            for (int i = 1; i < inputArray.Length; i++)
            {
                if (inputArray[i] == inputArray[i - 1])
                {
                    currentLength++;
                }
                else
                {
                    if (currentLength > maxLength)
                    {
                        maxLength = currentLength;
                        bestStartIndex = i - currentLength;
                    }
                    currentLength = 1;
                }
            }

            if (currentLength > maxLength)
            {
                maxLength = currentLength;
                bestStartIndex = inputArray.Length - currentLength;
            }

            for (int i = 0; i < maxLength; i++)
            {
                Console.Write(inputArray[bestStartIndex] + " ");
            }
        }
    }
}