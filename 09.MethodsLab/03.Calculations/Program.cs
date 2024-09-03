namespace _03.Calculations
{
    public class Program
    {
        static void Main()
        {
            string command = Console.ReadLine();
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            CalculateResult(command, firstNum, secondNum);
        }

        static void CalculateResult(string command,int a, int b)
        {
            if (command == "add")
            {
                Console.WriteLine(a + b);
            }
            else if (command == "multiply")
            {
                Console.WriteLine(a * b);
            }
            else if (command == "subtract")
            {
                Console.WriteLine(a - b);
            }
            else if (command == "divide")
            {
                Console.WriteLine(a / b);
            }
        }
    }
}