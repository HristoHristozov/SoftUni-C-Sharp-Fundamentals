namespace _04.Students
{
    internal class Program
    {
        static void Main()
        {
            int numberOfStudents = int.Parse(Console.ReadLine());

            List<Student> students = new List<Student>();

            for (int i = 0; i < numberOfStudents; i++)
            {
                string[] studentsData = Console.ReadLine().Split().ToArray();
                string firstName = studentsData[0];
                string lastName = studentsData[1];
                double grade = double.Parse(studentsData[2]);

                Student student = new Student(firstName, lastName, grade);
                students.Add(student);
            }

            var orderedStudents = students.OrderByDescending(x => x.Grade);
            foreach (var student in orderedStudents)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Grade:F2}");
            }
        }
    }


    public class Student
    {
        public Student(string firstName, string lastName, double grade)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }
    }
}
