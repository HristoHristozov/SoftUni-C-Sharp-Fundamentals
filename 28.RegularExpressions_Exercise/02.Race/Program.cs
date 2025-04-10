using System.Text.RegularExpressions;

namespace _02.Race
{
    internal class Program
    {
        static void Main()
        {
            var participantsInput = Console.ReadLine();
            if (participantsInput == null)
            {
                Console.WriteLine("No participants provided.");
                return;
            }

            List<string> participants = participantsInput
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            Dictionary<string, int> racersDistance = new Dictionary<string, int>();

            string? input;
            while ((input = Console.ReadLine()) != null && input != "end of the race")
            {
                string name = string.Concat(Regex.Matches(input, @"[A-Za-z]").Select(m => m.Value));
                int distance = Regex.Matches(input, @"\d")
                    .Select(d => int.Parse(d.Value))
                    .Sum();

                if (participants.Contains(name))
                {
                    if (!racersDistance.ContainsKey(name))
                    {
                        racersDistance[name] = 0;
                    }

                    racersDistance[name] += distance;
                }
            }

            var top3 = racersDistance
                .OrderByDescending(r => r.Value)
                .Take(3)
                .Select((r, i) => $"{(i + 1)}{GetSuffix(i + 1)} place: {r.Key}");

            foreach (var result in top3)
            {
                Console.WriteLine(result);
            }
        }

        static string GetSuffix(int number)
        {
            return number switch
            {
                1 => "st",
                2 => "nd",
                3 => "rd",
                _ => "th"
            };
        }
    }
}