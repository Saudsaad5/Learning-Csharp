namespace We_re_so_back
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your name ? ");
            String name = Console.ReadLine();
            Console.WriteLine("Hello " +name+"!");
            Console.WriteLine("How old are you ? ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You're " + age + " old!");

        }
    }
}
