namespace _02.AMinerTask
{
    internal class Program
    {
        static void Main()
        {
            var dict = new Dictionary<string, double>();
            string resource;

            while ((resource = Console.ReadLine()) != "stop")
            {
                double quantity = double.Parse(Console.ReadLine());

                if (!dict.ContainsKey(resource))
                {
                    dict.Add(resource, quantity);
                }
                else dict[resource] += quantity;
            }

            foreach (var kvp in dict)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
