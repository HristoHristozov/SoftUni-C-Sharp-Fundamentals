
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

        static void CalculateResult(string? command, int firstNum, int secondNum)
        {
            if (command == "add")
            {
                Console.WriteLine(firstNum + secondNum);
            }
            else if (command == "multiply")
            {
                Console.WriteLine(firstNum * secondNum);
            }
            else if (command == "subtract")
            {
                Console.WriteLine(firstNum - secondNum);
            }
            else if (command == "divide")
            {
                Console.WriteLine(firstNum / secondNum);
            }
        }
    }
}