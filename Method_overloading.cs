using System.ComponentModel.DataAnnotations;

namespace We_re_so_back
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1;
            double num2;
            double result;

            Console.WriteLine("Enter the 1st number: ");
            num1 =Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the 2nd number: ");
            num2 =Convert.ToDouble(Console.ReadLine());

            result = Mul(num1, num2);

            Console.WriteLine($"Result = {result}");
        }

        static double Mul(double num1, double num2) 
        { 
           return num1 * num2;
        }

        static double Mul(double num1, double num2, double num3)
        {
            return num1 * num2 * num3;
        }

    }
}
