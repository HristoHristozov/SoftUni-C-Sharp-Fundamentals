namespace _04.Students
{
    internal class Program
    {
        static void Main()
        {
            List<Students> students = new List<Students>();

            string input = "";
            while ((input = Console.ReadLine()) != "end")
            {
                List<string> studentsInfo = input.Split(" ").ToList();

                string firstName = studentsInfo[0];
                string lastName = studentsInfo[1];
                int age = int.Parse(studentsInfo[2]);
                string city = studentsInfo[3];

                Students student = new Students(firstName, lastName, age, city);
                students.Add(student);
            }

            string filterCity = Console.ReadLine();

            foreach (Students student in students)
            {
                if (student.HomeTown == filterCity)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }
        }
    }

    public class Students
    {
        public Students(string firstName, string lastName, int age, string homeTown)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            HomeTown = homeTown;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }
    }
}
