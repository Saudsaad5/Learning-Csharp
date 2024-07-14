using System.ComponentModel.DataAnnotations;

namespace We_re_so_back
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String[,] parkingLot = { { "Mustang", "F-150", "Explorer" },
                                                   { "Corvette", "Camaro", "Silverado" },
                                                   { "Corolla", "Camry", "Rav4" }
                                                 };


            for (int i = 0; i < parkingLot.GetLength(0); i++)
            {
                for (int j = 0; j < parkingLot.GetLength(1); j++)
                {
                    Console.Write(parkingLot[i, j] + " ");
                }
                Console.WriteLine();

            }
        }
    }
}
