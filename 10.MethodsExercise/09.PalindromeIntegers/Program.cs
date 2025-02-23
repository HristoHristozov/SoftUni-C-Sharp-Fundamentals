namespace _09.PalindromeIntegers
{
    internal class Program
    {
        static void Main()
        {
            string input;

            while ((input = Console.ReadLine().ToUpper()) != "END")
            {
                if (IsPalindrome(input)) Console.WriteLine("true");
                
                else Console.WriteLine("false");     
            }
        }

        static bool IsPalindrome(string input)
        {
            char[] reversed = input.ToCharArray();
            Array.Reverse(reversed);

            if (input == new string(reversed))
            {
                return true;
            }
            else return false;
        }
    }
}
