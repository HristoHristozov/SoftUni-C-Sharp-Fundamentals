namespace _03.Orders
{
    internal class Program
    {
        static void Main()
        {
            string command = "";

            var products = new Dictionary<string, Product>();

            while ((command = Console.ReadLine()) != "buy")
            {
                string[] tokens = command.Split().ToArray();
                string name = tokens[0];
                decimal price = decimal.Parse(tokens[1]);
                decimal quantity = decimal.Parse(tokens[2]);
                Product newProduct = new Product(name, price, quantity);
                if (!products.ContainsKey(name))
                {
                    products.Add(name, newProduct);
                }
                else products[name].Update(newProduct.Price, newProduct.Quantity);
            }

            foreach (Product product in products.Values)
            {
                Console.WriteLine(product);
            }
        }
    }

    class Product
    {
        public Product(string name, decimal price, decimal quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal Quantity { get; set; }

        public void Update(decimal price, decimal quantity)
        {
            Price = price;
            Quantity += quantity;
        }

        public decimal Result()
        {
            return Price * Quantity;
        }

        public override string ToString()
        {
            return $"{Name} -> {Price * Quantity}";
        }
    }
}
