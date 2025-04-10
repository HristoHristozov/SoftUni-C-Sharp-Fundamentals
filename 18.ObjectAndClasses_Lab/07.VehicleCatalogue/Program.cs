namespace _07.VehicleCatalogue
{
    internal class Program
    {
        static void Main()
        {
            Catalog catalog = new Catalog();

            string input = "";

            while ((input = Console.ReadLine()) != "end")
            {
                string[] data = input.Split("/").ToArray();

                string type = data[0];
                string brand = data[1];
                string model = data[2];
                int hpOrWeight = int.Parse(data[3]);

                if (type == "Car")
                {
                    catalog.Cars.Add(new Car(brand, model, hpOrWeight));

                }

                else if (type == "Truck")
                {
                    catalog.Trucks.Add(new Truck(brand, model, hpOrWeight));
                }
            }

            if (catalog.Cars.Count > 0)
            {
                Console.WriteLine("Cars:");

                foreach (Car car in catalog.Cars.OrderBy(car => car.Brand))
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }

            if (catalog.Trucks.Count > 0)
            {
                Console.WriteLine("Trucks:");
                foreach (Truck truck in catalog.Trucks.OrderBy(truck => truck.Brand))
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }

        }
    }

    public class Truck
    {
        public Truck(string brand, string model, int weight)
        {
            Brand = brand;
            Model = model;
            Weight = weight;
        }

        public string Brand { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }

    }

    public class Car
    {
        public Car(string brand, string model, int horsePower)
        {
            Brand = brand;
            Model = model;
            HorsePower = horsePower;
        }

        public string Brand { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
    }

    public class Catalog
    {
        public Catalog()
        {
            Cars = new List<Car>();
            Trucks = new List<Truck>();
        }

        public List<Car> Cars { get; set; }
        public List<Truck> Trucks { get; set; }
    }
}

