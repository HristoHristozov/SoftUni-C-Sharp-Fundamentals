namespace _07.NxNMatrix
{
    internal class Program
    {
        static void Main()
        {
            int matrixLenght = int.Parse(Console.ReadLine());

            PrintMatrix(matrixLenght);
        }

        static void PrintMatrix(int a)
        {
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    Console.Write($"{a} ");
                }
                Console.WriteLine();
            }

        }
    }
}
