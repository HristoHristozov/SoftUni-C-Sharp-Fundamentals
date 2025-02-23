namespace _04.PasswordValidator
{
    internal class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            bool isValid = ValidatePassword(input);

            if (isValid)
            {
                Console.WriteLine("Password is valid");
            }
        }

        static bool ValidatePassword(string password)
        {
            bool isValid = true;

            if (!IsLengthValid(password))
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                isValid = false;
            }

            if (!IsOnlyLettersAndDigits(password))
            {
                Console.WriteLine("Password must consist only of letters and digits");
                isValid = false;
            }

            if (!HasAtLeastTwoDigits(password))
            {
                Console.WriteLine("Password must have at least 2 digits");
                isValid = false;
            }

            return isValid;
        }

        static bool IsLengthValid(string password) => password.Length >= 6 && password.Length <= 10;

        static bool IsOnlyLettersAndDigits(string password) => password.All(char.IsLetterOrDigit);

        static bool HasAtLeastTwoDigits(string password) => password.Count(char.IsDigit) >= 2;
    }
}
