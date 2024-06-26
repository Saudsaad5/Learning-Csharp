namespace We_re_so_back
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a Random obj
            Random ran = new Random();
            //Set it's range from 0 to 10
            int num1 = ran.Next(0, 11);
            Console.WriteLine(num1);

            // You can create more than one Random Number from the same obj
            int num2 = ran.Next(0, 21);
            Console.WriteLine(num2);


        }
    }
}
