using System;

namespace EpicDiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //mängus oseleb 2 mängijat
            //iga mängija viskab täringut (1-6);
            //programm kuvab nende visete tulemust ja kuvab ka, kes on võitja
            //ehk kes viskas suuremat

            Random rnd = new Random();

            string PlayerOne = "Harry Potter,";
            string PlayerTwo = "lkqwe";
            
                int HarryThrow = rnd.Next(1, 7);
            int lkqweThrow = rnd.Next(1, 7);

            Console.WriteLine($" {PlayerOne} threw {HarryThrow};");
            Console.WriteLine($" {PlayerTwo} threw {lkqweThrow};");


            if (HarryThrow > lkqweThrow)
            {
                Console.WriteLine($"{PlayerOne} wins!");
            }
            else if (HarryThrow < lkqweThrow)
            {
                Console.WriteLine($"{PlayerTwo} wins!");
            }
            else
            {
                Console.WriteLine("draw! let them try again!");
            }

        }
    }
}
