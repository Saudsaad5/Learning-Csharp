using System.ComponentModel.DataAnnotations;

namespace We_re_so_back
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            bool run = true;
            

            Console.WriteLine("Wellcome to the calculator program!");

            while (run)
            {
                double num1 = 0;
                double num2 = 0;
                double result = 0;
                String again = "";
                String ope = "";

                Console.WriteLine("Enter Number 1: ");
                num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Number 2: ");
                num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Select an Operation: ");
                Console.WriteLine("\t+ : Add");
                Console.WriteLine("\t- : Subtract");
                Console.WriteLine("\t* : Multiply");
                Console.WriteLine("\t/ : Divide");
                Console.Write("Enter an option: ");

                ope = Console.ReadLine();

                switch (ope)
                {
                    case ("+"):
                        result = num1 + num2;
                        Console.WriteLine($"Your result: {num1} + {num2} = " + result);
                        break;
                    case "-":
                        result = num1 - num2;
                        Console.WriteLine($"Your result: {num1} - {num2} = " + result);
                        break;
                    case "*":
                        result = num1 * num2;
                        Console.WriteLine($"Your result: {num1} * {num2} = " + result);
                        break;
                    case "/":
                        result = num1 / num2;
                        Console.WriteLine($"Your result: {num1} / {num2} = " + result);
                        break;
                    default:
                        Console.WriteLine("That was not a valid option");
                        break;

                }
                Console.WriteLine("Do you want to do another oreration? (Y/N):  ");
                again = Console.ReadLine();
                again = again.ToUpper();

                if (again == "Y")
                {
                    run = true;
                }
                else
                {
                    run = false;
                }
            }
            Console.WriteLine("Tank You For Using Our Calculator Program!");
        }
    }
}
