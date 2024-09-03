namespace _11.MathOperations
{
    public class Program
    {
        static void Main()
        {
            double firstNum = double.Parse(Console.ReadLine());
            string sign = Console.ReadLine();
            double secondNum = double.Parse(Console.ReadLine());

            Console.WriteLine(Calculate(firstNum,sign,secondNum));       
        }

        static double Calculate(double a, string sign, double b)
        {
            double result = 0;

            if (sign == "/")
            {
                result = a / b;
            }
            else if (sign == "-")
            {
                result = a - b;
            }
            else if (sign == "*")
            {
                result = a * b;
            }
            else if (sign == "+")
            {
                result = a + b;
            }

            return result;
        }

    }
}