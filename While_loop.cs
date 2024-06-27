using System.ComponentModel.DataAnnotations;

namespace We_re_so_back
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String name = "";

            while (name == "")
            {
                Console.WriteLine("Enter your  name");
                name = Console.ReadLine();
            }
            Console.WriteLine("Hello " + name +"!");
        }
    }
}
