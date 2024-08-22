namespace _01.DataTypeFinder
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string input = "";
            int valueofInt;
            float valueOfFloat;
            char valueOfChar;
            bool valueOfBool;

            while ((input = Console.ReadLine()) != "END")           
            {


                if (int.TryParse(input, out valueofInt))
                {
                    Console.WriteLine($"{input} is integer type");
                }

                else if (float.TryParse(input, out valueOfFloat))
                {
                    Console.WriteLine($"{input} is floating point type");
                }

                else if (char.TryParse(input, out valueOfChar))
                {
                    Console.WriteLine($"{input} is character type");
                }

                else if (bool.TryParse(input, out valueOfBool))
                {
                    Console.WriteLine($"{input} is boolean type");
                }

                else Console.WriteLine($"{input} is string type");


            }

        }
    }
}