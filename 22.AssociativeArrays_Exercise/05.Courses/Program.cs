namespace _05.Courses
{
    internal class Program
    {
        static void Main()
        {
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();

            string input = "";
            while ((input = Console.ReadLine()) != "end")
            {
                string[] tokens = input.Split(":").ToArray();
                var course = tokens[0].Trim();
                var name = tokens[1];

                if (!courses.ContainsKey(course))
                {
                    courses.Add(course, new List<string>());

                }
                courses[course].Add(name);

            }

            foreach (var course in courses)
            {
                var students = course.Value;
                Console.WriteLine($"{course.Key}: {students.Count}");
                foreach (var student in students)
                {
                    Console.WriteLine($"--{student}");
                }
            }
        }
    }
}
