namespace Day2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var input = File.ReadAllLines("input.txt");


            // Part one
            var score = 0;

            foreach (var line in input)
            {
                var opponent = line[0];
                var player = line[2];

                // Add score for selection;
                score += player - 87;

                switch (opponent)
                {
                    case 'A':
                        switch (player)
                        {
                            case 'X': // Draw
                                score += 3;
                                break;
                            case 'Y': // Win
                                score += 6;
                                break;
                            default:
                                break;
                        }
                        break;
                    case 'B':
                        switch (player)
                        {
                            case 'Y': // Draw
                                score += 3;
                                break;
                            case 'Z': // Win
                                score += 6;
                                break;
                            default:
                                break;
                        }
                        break;
                    case 'C':
                        switch (player)
                        {
                            case 'Z': // Draw
                                score += 3;
                                break;
                            case 'X': // Win
                                score += 6;
                                break;
                            default:
                                break;
                        }
                        break;
                }
            }

            Console.WriteLine($"Part one -- {score}");

            // Part  two
            score = 0;
            foreach (var line in input)
            {
                var opponent = line[0];
                var player = line[2];

                switch (opponent)
                {
                    case 'A': // Rock
                        switch (player)
                        {
                            case 'X': // Lose
                                score += 3;
                                break;
                            case 'Y': // Draw
                                score += 1;
                                score += 3;
                                break;
                            case 'Z': // Win
                                score += 2;
                                score += 6;
                                break;
                            default:
                                break;
                        }
                        break;
                    case 'B': // Paper
                        switch (player)
                        {
                            case 'X': // Lose
                                score += 1;
                                break;
                            case 'Y': // Draw
                                score += 2;
                                score += 3;
                                break;
                            case 'Z': // Win
                                score += 3;
                                score += 6;
                                break;
                            default:
                                break;
                        }
                        break;
                    case 'C': // Scissors
                        switch (player)
                        {
                            case 'X': // Lose
                                score += 2;
                                break;
                            case 'Y': // Draw
                                score += 3;
                                score += 3;
                                break;
                            case 'Z': // Win
                                score += 1;
                                score += 6;
                                break;
                            default:
                                break;
                        }
                        break;
                }
            }

            Console.WriteLine($"Part two -- {score}");


        }
    }
}