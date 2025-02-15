namespace _04.ArrayRotation
{
    public class Program
    {
        static void Main()
        {
            int[] inputArray = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int numberOfRotations = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfRotations; i++)
            {
                int temp = inputArray[0];

                for (int j = 0; j < inputArray.Length - 1; j++)
                {
                    inputArray[j] = inputArray[j + 1];
                }

                inputArray[inputArray.Length - 1] = temp;
            }

            Console.WriteLine(String.Join(' ', inputArray));
        }
    }
}