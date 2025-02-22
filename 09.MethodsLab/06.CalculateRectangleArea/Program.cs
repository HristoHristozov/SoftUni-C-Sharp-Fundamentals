namespace _06.CalculateRectangleArea
{
    public class Program
    {
        static void Main()
        {
            double rectangleSideA = double.Parse(Console.ReadLine());
            double rectangleSideB = double.Parse(Console.ReadLine());

            Console.WriteLine(GetRectangleArea(rectangleSideA,rectangleSideB));
        }

        static double GetRectangleArea(double a, double b)
        {
            return a * b;
        }
    }
}