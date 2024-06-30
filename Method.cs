using System.ComponentModel.DataAnnotations;

namespace We_re_so_back
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String name = "Saud";
            int age = 23;
            Method(name, age);
        }

        static void Method(String name, int age) 
        { 
            Console.WriteLine($"Hello {name}!");
            Console.WriteLine($"You're a {age} old");
        }

    }
}
