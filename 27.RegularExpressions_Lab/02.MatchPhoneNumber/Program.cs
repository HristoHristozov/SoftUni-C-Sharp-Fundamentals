using System.Text.RegularExpressions;

namespace _02.MatchPhoneNumber
{
    internal class Program
    {
        static void Main()
        {
            string pattern = @"(\+359([ -])2(\2)(\d{3})(\2)(\d{4}))\b";

            string phoneNum = Console.ReadLine();

            MatchCollection phoneMatches = Regex.Matches(phoneNum, pattern);

            var matchedPhones = phoneMatches
                .Cast<Match>()
                .Select(x => x.Value.Trim())
                .ToList();

            Console.WriteLine(string.Join(", ", matchedPhones));
        }
    }
}
