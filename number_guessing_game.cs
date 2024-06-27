using System.ComponentModel.DataAnnotations;

namespace We_re_so_back
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random ran = new Random();
            int min = 0;
            int max = 100;
            int guess;
            int number;
            int guesses;
            String response;
            bool play_again = true;

            while (play_again) {

                guess = 0;
                guesses = 0;
                response = "";
                number = ran.Next(min, max +1);

                while (guess != number)
                {
                    Console.WriteLine("Guess the number between " + min + " and " + max + " : ");
                    guess = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Guess: " + guess);

                    if (guess > number)
                    {
                        Console.WriteLine(guess + " is too high");
                    }
                    else if (guess < number) { 
                        Console.WriteLine(guess + " is too low");
                    }
                    guesses++;
                }
                Console.WriteLine("Number: " + number);
                Console.WriteLine("YOU WIN!");
                Console.WriteLine("Guesses: " + guesses);

                Console.WriteLine("Would you like to play again (Y/N): ");
                response = Console.ReadLine();
                response = response.ToUpper();

                if (response == "Y")
                {
                    play_again = true;
                }
                else { 
                     play_again = false;
                }

            }
            Console.WriteLine("Thank you for playing!");

        }
    }
}
