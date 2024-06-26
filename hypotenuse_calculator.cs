namespace We_re_so_back
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter side A: ");
            double a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter side b: ");
            double b = Convert.ToInt32(Console.ReadLine());

          double c = Math.Sqrt(a * a ) + ( b * b);
            Console.WriteLine("The hypotenuse is: " + c);


        }
    }
}
