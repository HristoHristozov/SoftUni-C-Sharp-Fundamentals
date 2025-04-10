namespace _05.Students2._0
{
    internal class Program
    {
        static void Main()
        {
            List<Student> students = new List<Student>();

            string input = "";
            while ((input = Console.ReadLine()) != "end")
            {
                List<string> studentInformation = input.Split(" ").ToList();
                string firstName = studentInformation[0];
                string lastName = studentInformation[1];
                int age = int.Parse(studentInformation[2]);
                string City = studentInformation[3];

                Student student = students.FirstOrDefault(students => students.FirstName == firstName && students.LastName == lastName);

                if (student == null)
                {
                    students.Add(new Student(firstName, lastName, age, City));
                }

                else
                {
                    student.City = City;
                    student.Age = age;
                }

            }

            string filterCity = Console.ReadLine();

            foreach (Student student in students)
            {
                if (student.City == filterCity)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }


        }
    }


    public class Student
    {
        public Student(string firstName, string lastName, int age, string city)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            City = city;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string City { get; set; }

    }
}
  