namespace _1.DataTypes
{
    internal class Program
    {
        static void Main()
        {
            string type = Console.ReadLine();
            string input = Console.ReadLine(); 

            ProcessInput(type, input);
        }

        static void ProcessInput(string type, string input)
        {
            switch (type)
            {
                case "int":
                    ProcessInt(input);
                    break;
                case "real":
                    ProcessReal(input);
                    break;
                case "string":
                    ProcessString(input);
                    break;
            }
        }

        static void ProcessInt(string input)
        {
            int intValue = int.Parse(input);
            Console.WriteLine(intValue * 2);
        }

        static void ProcessReal(string input)
        {
            double doubleValue = double.Parse(input);
            Console.WriteLine($"{doubleValue * 1.5:F2}");
        }

        static void ProcessString(string input)
        {
            Console.WriteLine($"${input}$");
        }
    }
}
