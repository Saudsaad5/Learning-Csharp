using System.ComponentModel.DataAnnotations;

namespace We_re_so_back
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random ran = new Random();
            String player;
            String npc;
            String answer;
            bool playagain = true;

            while (playagain)
            {
                player = "";
                npc = "";
                answer = "";

                while (player != "ROCK" && player != "PAPER" && player != "SCISSORS")
                {
                    Console.WriteLine("Enter ROCK, PAPER, or SCISSORS: ");
                    player = Console.ReadLine();
                    player = player.ToUpper();
                }

                switch(ran.Next(1 , 4))
                {
                    case 1:
                        npc = "ROCK";
                        break;
                    case 2:
                        npc = "PAPER";
                        break ;
                    case 3:
                        npc = "SCISSORS";
                        break ;
                }
                Console.WriteLine("Player: " + player);
                Console.WriteLine("Npc: " + npc);

                switch(player)
                {
                    case "ROCK":
                        if (npc == "ROCK")
                        {
                            Console.WriteLine("It's draw!");
                        }
                        else if (npc == "PAPER")
                        {
                            Console.WriteLine("You lost this round!");
                        }
                        else
                        {
                            Console.WriteLine("You win!");
                        }
                        break;

                    case "PAPER":
                        if (npc == "PAPER")
                        {
                            Console.WriteLine("It's draw!");
                        }
                        else if (npc == "SCISSORS")
                        {
                            Console.WriteLine("You lost this round!");
                        }
                        else
                        {
                            Console.WriteLine("You win!");
                        }
                        break;

                    case "SCISSORS":
                        if (npc == "SCISSORS")
                        {
                            Console.WriteLine("It's draw!");
                        }
                        else if (npc == "ROCK")
                        {
                            Console.WriteLine("You lost this round!");
                        }
                        else
                        {
                            Console.WriteLine("You win!");
                        }
                        break;
                }
                Console.WriteLine("Would you like to play again? (Y/N): ");
                answer = Console.ReadLine();
                answer = answer.ToUpper();

                if (answer == "Y")
                {
                    playagain = true;
                }
                else
                {
                    playagain = false;
                }
            }
            Console.WriteLine("Thank You For Playing!");
        }
    }
}
