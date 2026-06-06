namespace RockPaperScissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool playAgain = true;
            String player;
            String computer;
            String answer;
            int score = 0;

            while (playAgain)
            {
                player = "";
                computer = "";
                answer = "";

                while (player != "ROCK" && player != "PAPER" && player != "SCISSORS")
                {
                    Console.WriteLine("ENTER ROCK, PAPER, or SCISSORS: ");
                    player = Console.ReadLine();
                    player = player.ToUpper();
                }

                int x = random.Next(1, 4);

                switch (x)
                {
                    case 1:
                        computer = "ROCK";
                        break;
                    case 2:
                        computer = "PAPER";
                        break;
                    case 3:
                        computer = "SCISSORS";
                        break;
                }

                if (player == "ROCK" && computer == "SCISSORS")
                {
                    Console.WriteLine($"You picked {player} computer picked {computer}.You WIN!!");
                    score++;
                }
                else if (player == "PAPER" && computer == "ROCK")
                {
                    Console.WriteLine($"You picked {player} computer picked {computer}.You WIN!!");
                    score++;
                }
                else if (player == "SCISSORS" && computer == "PAPER")
                {
                    Console.WriteLine($"You picked {player} computer picked {computer}.You WIN!!");
                    score++;
                }
                else if (player == computer)
                {
                    Console.WriteLine($"You picked {player} computer picked {computer}.Its draw");
                }

                else
                {
                    Console.WriteLine($"You picked {player} computer picked {computer}.You lose");
                    score--;
                }

                Console.WriteLine("Play again? Y/N: ");
                answer = Console.ReadLine();
                answer = answer.ToUpper();

                switch (answer)
                {
                    case "Y":
                        playAgain = true;
                        break;
                    case "N":
                        playAgain = false;
                        Console.WriteLine($"Your score: {score}");
                        break;
                    default:
                        playAgain = true;
                        break;
                }
            }
        }
    }
}
