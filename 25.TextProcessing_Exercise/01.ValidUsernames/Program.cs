namespace _01.ValidUsernames
{
    internal class Program
    {
        static void Main()
        {
            string[] usernames = Console.ReadLine().Split(", ");

            bool isValid = false;

            foreach (string username in usernames)
            {
                if (username.Length > 2 && username.Length < 17 && IsValid(username))
                {
                    Console.WriteLine(username);
                }
            }
        }

        static bool IsValid(string user)
        {
            foreach (var symbol in user)
            {
                if (char.IsLetterOrDigit(symbol) || symbol == '-' || symbol == '_')
                {
                    continue;
                }
                else return false;
            }

            return true;
        }
    }
}