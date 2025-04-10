namespace _06.VehicleCatalogue
{
    internal class Program
    {
        static void Main()
        {

            string input = "";

            List<Vehicle> vehicles = new List<Vehicle>();
            while ((input = Console.ReadLine()) != "End")
            {
                string[] data = input.Split().ToArray();
                string typeOfVehicle = data[0];
                string vehicleMake = data[1];
                string color = data[2];
                decimal hP = decimal.Parse(data[3]);

                Vehicle vehicle = new Vehicle(typeOfVehicle, vehicleMake, color, hP);
                vehicles.Add(vehicle);
            }

            while ((input = Console.ReadLine()) != "Close the Catalogue")
            {

                Vehicle vehicle = vehicles.Find(vehicle => vehicle.Make.Equals(input));
                if (vehicle != null)
                {
                    Console.WriteLine(vehicle.Print());
                }
            }

            decimal averageHPCar = vehicles
                .Where(x => x.Type == "Car")
                .Select(x => x.HP)
                .DefaultIfEmpty()
                .Average();
            decimal averageHPTruck = vehicles
                .Where(x => x.Type == "Truck")
                .Select(x => x.HP)
                .DefaultIfEmpty()
                .Average();

            Console.WriteLine($"Cars have average horsepower of: {averageHPCar:F2}.");
            Console.WriteLine($"Trucks have average horsepower of: {averageHPTruck:F2}.");
        }
    }

    public class Vehicle
    {
        public Vehicle(string type, string make, string color, decimal hP)
        {
            Type = type;
            Make = make;
            Color = color;
            HP = hP;
        }
        private string type;
        public string Type
        {
            get
            {
                return type;
            }
            set
            {
                type = CapitalizeWord(value);
            }
        }

        public string Make { get; set; }
        public string Color { get; set; }
        public decimal HP { get; set; }

        public string CapitalizeWord(string value)
        {
            char[] charArray = value.ToCharArray();
            if (char.IsLower(charArray[0]))
            {
                charArray[0] = char.ToUpper(charArray[0]);
            }

            return new string(charArray);
        }
        public string Print()
        {
            string result = "";
            result += $"Type: {Type}\n";
            result += $"Model: {Make}\n";
            result += $"Color: {Color}\n";
            result += $"Horsepower: {HP}";
            return result;
        }
    }
}
 
