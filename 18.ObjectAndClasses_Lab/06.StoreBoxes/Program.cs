namespace _06.StoreBoxes
{
    internal class Program
    {
        static void Main()
        {
            string input = "";

            List<Box> boxes = new List<Box>();

            while ((input = Console.ReadLine()) != "end")
            {
                string[] data = input.Split().ToArray();

                string serialNumber = data[0];
                string itemName = data[1];
                int itemQuantity = int.Parse(data[2]);
                decimal price = decimal.Parse(data[3]);

                Item item = new Item(itemName, price);

                Box box = new Box(serialNumber, item, itemQuantity);
                boxes.Add(box);

            }

            foreach (Box box in boxes.OrderByDescending(x => x.BoxPrice))
            {
                Console.WriteLine($"{box.SerialNumber}");
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:F2}: {box.Quantity}");
                Console.WriteLine($"-- ${box.BoxPrice:F2}");
            }
        }
    }

    public class Item
    {
        public Item(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public string Name { get; set; }
        public decimal Price { get; set; }
    }

    public class Box
    {
        public Box(string serialNumber, Item item, int quantity)
        {
            SerialNumber = serialNumber;
            Item = item;
            Quantity = quantity;
        }

        public string SerialNumber { get; set; }
        public Item Item { get; set; }
        public int Quantity { get; set; }
        public decimal BoxPrice => Item.Price * Quantity;

    }
}
     