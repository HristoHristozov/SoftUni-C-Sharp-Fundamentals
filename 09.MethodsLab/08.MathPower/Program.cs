namespace _08.MathPower
{
    public class Program
    {
        static void Main()
        {
            double baseNumber = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());

            Console.WriteLine(MathPower(baseNumber,power));
        }

        static double MathPower(double a, double b)
        {
            double result = Math.Pow(a, b);
            return result;
        }
    }
}