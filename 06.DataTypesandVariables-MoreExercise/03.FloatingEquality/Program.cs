namespace _03.FloatingEquality
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstNum = double.Parse(Console.ReadLine());
            double secondNum = double.Parse(Console.ReadLine());

            double eps = 0.000001;

            bool isEqual = Math.Abs(firstNum - secondNum) < eps;

            Console.WriteLine(isEqual);



        }
    }
}