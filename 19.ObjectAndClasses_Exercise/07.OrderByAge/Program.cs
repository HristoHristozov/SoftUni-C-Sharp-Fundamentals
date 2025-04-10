namespace _07.OrderByAge
{
    internal class Program
    {
        static void Main()
        {
            string input = "";

            List<People> people = new List<People>();
            while ((input = Console.ReadLine()) != "End")
            {
                string[] tokens = input.Split().ToArray();
                string name = tokens[0];
                string ID = tokens[1];
                int age = int.Parse(tokens[2]);

                var filiteredPpl = people
                    .FirstOrDefault(x => x.ID == ID);
                if (filiteredPpl == null)
                {
                    people.Add(new People(name, ID, age));
                }
                else
                {
                    filiteredPpl.Age = age;
                    filiteredPpl.Name = name;
                }
            }

            foreach (var person in people.OrderBy(x => x.Age))
            {
                Console.WriteLine($"{person.Name} with ID: {person.ID} is {person.Age} years old.");
            }
        }
    }

    public class People
    {
        public People(string name, string iD, int age)
        {
            Name = name;
            ID = iD;
            Age = age;
        }

        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }
    }
}

