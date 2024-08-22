namespace _06.BalancedBrackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            byte inputLines = byte.Parse(Console.ReadLine());

            byte countOpeningBrackets = 0;
            byte countClosingBrackets = 0;

            for (int i = 0; i < inputLines; i++)
            {
                string input = Console.ReadLine();

                if (input == "(")
                {
                    countOpeningBrackets++;
                }
                else if (input == ")")
                {
                    countClosingBrackets++;
                    if (countOpeningBrackets - countClosingBrackets != 0)
                    {
                        Console.WriteLine("UNBALANCED");
                        return;
                    }
                }
            }

            if (countOpeningBrackets == countClosingBrackets)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }

        }
    }
}