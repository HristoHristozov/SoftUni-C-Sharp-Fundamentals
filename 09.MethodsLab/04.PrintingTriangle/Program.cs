namespace _04.PrintingTriangle
{
    public class Program
    {
        static void Main()
        {
            int triangleNums = int.Parse(Console.ReadLine());

            PrintTriangle(triangleNums);
        }

        static void PrintTriangle(int triangleNums)
        {
            for (int i = 1; i <= triangleNums; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }

            for (int row = triangleNums - 1; row >= 0; row--)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write(col + " ");
                }
                Console.WriteLine();
            }
        }
    }
}