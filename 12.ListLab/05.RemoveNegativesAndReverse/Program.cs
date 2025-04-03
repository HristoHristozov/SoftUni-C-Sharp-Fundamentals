namespace _05.RemoveNegativesAndReverse
{
    internal class Program
    {
        static void Main()
        {

            var list = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            list.RemoveAll(n => n < 0);

            if (list.Count == 0)
            {
                Console.WriteLine("empty");
                return;
            }

            list.Reverse();
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
        }
    }
}
