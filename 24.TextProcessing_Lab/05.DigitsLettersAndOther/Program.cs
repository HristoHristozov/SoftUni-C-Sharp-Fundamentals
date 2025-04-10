namespace _05.DigitsLettersAndOther
{
    internal class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            var allDigits = input.Where(char.IsDigit);
            var allLetters = input.Where(char.IsLetter);
            var allCharaters = input.Where(x => !char.IsLetterOrDigit(x));

            Console.WriteLine(string.Join("", allDigits));
            Console.WriteLine(string.Join("", allLetters));
            Console.WriteLine(string.Join("", allCharaters));
        }
    }
}
