namespace _06.CalculateRectangleArea
{
    public class Program
    {
        static void Main()
        {
            double rectangleASide = double.Parse(Console.ReadLine());
            double rectangleBSide = double.Parse(Console.ReadLine());

            double area = CalculateRectangleArea(rectangleASide, rectangleBSide);
            Console.WriteLine(area);
        }

        static double CalculateRectangleArea(double a , double b)
        {
            return a * b;
        }
    }
}