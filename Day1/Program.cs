
namespace Day1
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Part one
            var input = File.ReadAllLines("input.txt");
            List<int> totals = new();
            totals.Add(0);
            var sum = 0;
            foreach (var line in input)
            {
                if (line == "")
                {
                    totals.Add(sum);
                    sum = 0;
                    continue;
                }
                sum += Int32.Parse(line);
            }

            var biggestTotal = totals.Max();
            Console.WriteLine($"Part One -- {biggestTotal}");
            
            // Part two
            totals.Sort();
            var sumOfTopThree = totals[^1] + totals[^2] + totals[^3];
            Console.WriteLine($"Part Two -- {sumOfTopThree}");

        }
    }
}
