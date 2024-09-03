namespace _09.GreaterOfTwoValues
{
    public class Program
    {
        static void Main()
        {      
            string inputType = Console.ReadLine();

            CheckInput(inputType);
        }

        static void CheckInput(string inputType)
        {
            if (inputType == "int")
            {
                int firstNum = int.Parse(Console.ReadLine());
                int secondNum = int.Parse(Console.ReadLine());
                if (firstNum > secondNum)
                {
                    Console.WriteLine(firstNum);
                }
                else Console.WriteLine(secondNum);
            }

            else if (inputType == "char")
            {
                char firstChar = char.Parse(Console.ReadLine());
                char secondChar = char.Parse(Console.ReadLine());
                if (firstChar > secondChar)
                {
                    Console.WriteLine(firstChar);
                }
                else Console.WriteLine(secondChar);
            }

            else if (inputType == "string")
            {
                string firstString = Console.ReadLine();
                string secondString = Console.ReadLine();
                int compareLinguistic = String.Compare(firstString, secondString, StringComparison.InvariantCulture);

                if (compareLinguistic > 0)
                {
                    Console.WriteLine(firstString);
                }
                else Console.WriteLine(secondString);
            }
        }

    }
}