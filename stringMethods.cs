using System.ComponentModel.DataAnnotations;

namespace We_re_so_back
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String name = "Saud saad";
            // to change the litters to ""cap or small
            name = name.ToUpper();
            name = name.ToLower();
            Console.WriteLine(name);

            // to reaplace any char
            String phone = "123-456-7890";
            phone = phone.Replace("-", "");
            Console.WriteLine(phone);

            // you can see how many chars in a string
            Console.WriteLine(name.Length);

            String firstName = name.Substring(0, 3);
            Console.WriteLine(firstName);

            String lastName = name.Substring(5, 8);
            Console.WriteLine(lastName);

            // you can insert anything at any given index
            name = name.Insert(0, "@");
            Console.WriteLine(name);


        }
    }
}
