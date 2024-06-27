using System.ComponentModel.DataAnnotations;

namespace We_re_so_back
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age to sign in: ");
            String init = Console.ReadLine();
            bool isNumeric = init.All(char.IsDigit);
            int age = Convert.ToInt32(init);

            if (age == null)
            {
                Console.WriteLine("You didn't enter anything!");
            }
            else if (isNumeric == false)
            {
                Console.WriteLine("You must enter numbers only");
            }
            else if (age > 100)
            {
                Console.WriteLine("You're to old to sign in!");
            }
            else if (age >= 18)
            {
                Console.WriteLine("You're signed up!");
            }
            else if (age == 0)
            {
                Console.WriteLine("You're not born yet!");
            }
            else if (age < 18)
            {
                Console.WriteLine("You're to young to sign up!");
            }
    }   }
}
