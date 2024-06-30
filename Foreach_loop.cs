using System.ComponentModel.DataAnnotations;

namespace We_re_so_back
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String[] cars = { "Toyota", "BMW", "Mustang" };

            foreach (String car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }
}
