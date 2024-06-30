using System.ComponentModel.DataAnnotations;

namespace We_re_so_back
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string init;
            bool isNumeric = false;

            Console.WriteLine("Enter the amount of numbers you want to store:");

            do
            {
                init = Console.ReadLine();
                isNumeric = init.All(char.IsDigit); 

                if (!isNumeric)
                {
                    Console.WriteLine("Invalid input! Please enter a numeric value:");
                }

            } while (!isNumeric); 

            int index = Convert.ToInt32(init); 

            int[] nums = new int[index]; 

            
            for (int i = 0; i < index; i++)
            {
                Console.WriteLine($"Enter the number at index {i}:");
                int num = Convert.ToInt32(Console.ReadLine());
                nums[i] = num; 
            }

            
            Console.WriteLine("Numbers entered:");
            for (int i = 0; i < index; i++)
            {
                Console.WriteLine($"nums[{i}] = {nums[i]}");
            }






        }
    }
}
