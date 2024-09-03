namespace _04.PrintingTriangle
{
    public class Program
    {
        static void Main()
        {
            int triangleNums = int.Parse(Console.ReadLine());

            PrintTraingle(triangleNums);
        }

        static void PrintTraingle(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                    
                }
                Console.WriteLine();
            }

            for (int row = n - 1; row >= 0; row--)
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