namespace _04_WordFilter
{
    internal class Program
    {
        static void Main()
        {
            List<string> list = Console.ReadLine().Split().Where(x => x.Length % 2 == 0).ToList();

            foreach (string word in list)
            {
                Console.WriteLine(word);
            }
        }
    }
}
