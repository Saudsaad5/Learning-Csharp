using System.ComponentModel.DataAnnotations;

namespace We_re_so_back
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Double temp = 20;
            String message;

            message = (temp >= 20) ? "It's warm outside!" : "It's cold outside!";
            Console.WriteLine(message);


        }



    }
}
