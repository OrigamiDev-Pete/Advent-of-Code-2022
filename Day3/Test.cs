namespace Day3;

public class Test
{
    public static void Run()
    {
        var input = File.ReadAllLines("input.test");

        // Part One ---

        var total = 0;
        foreach (var rucksack in input)
        {
            var compartment1 = rucksack.Substring(0, rucksack.Length / 2);
            var compartment2 = rucksack.Substring(rucksack.Length / 2);
            var compartmentCheck1 = CheckItems(compartment1);
            var compartmentCheck2 = CheckItems(compartment2);

            for (int i = 0; i < compartmentCheck1.Length; i++)
            {
                if (compartmentCheck1[i] && compartmentCheck2[i])
                {
                    total += i + 1;
                }
            }
        }

        Console.WriteLine($"Expected: 157 -- Found: {total}");

        total = 0;
        for (int i = 0; i < input.Length; i += 3)
        {
            var elfCheck1 = CheckItems(input[i]);
            var elfCheck2 = CheckItems(input[i + 1]);
            var elfCheck3 = CheckItems(input[i + 2]);

            for (int j = 0; j < elfCheck1.Length; j++)
            {
                if (elfCheck1[j] && elfCheck2[j] && elfCheck3[j])
                {
                    total += j + 1;
                }
            }
        }

        Console.WriteLine($"Expected: 70 -- Found: {total}");
    }

    public static bool[] CheckItems(string compartment)
    {
        var compartmentCheck = new bool[52];
        foreach (var item in compartment)
        {
            var i = item;
            if (i >= 'a')
            {
                i -= 'a';
                compartmentCheck[i] = true;
            }
            else
            {
                i -= 'A';
                i += (char)26;
                compartmentCheck[i] = true;
            }
        }

        return compartmentCheck;
    }


}