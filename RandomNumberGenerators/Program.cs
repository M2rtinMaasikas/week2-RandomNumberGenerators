using System;

namespace RandomNumberGenerators
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int MyRandomNumber = rnd.Next(5, 16);

            //programm genereerib juhuslikku numbrit
            //programm kontrollib, kas genereeritud number on 
            //suuerm kui 5
            //kui number on suurem kui 5 siis konsool kuvab
            //juhsulik number on MyRandomNumber, see on väiksem
            //kui 5
            //kui number on 5, siis konsool kuvab "juhuslik number on 5"



            Console.WriteLine($"arvuti genereeris: {MyRandomNumber}");
            if(MyRandomNumber > 5)
            {
                Console.WriteLine($"juhuslik number {MyRandomNumber}, see on suurem, kui 5");
            }
            else if (MyRandomNumber < 5)
            {
                Console.WriteLine($"juhuslik number {MyRandomNumber}, see on väiksem, kui 5");
            }
            
            else 
            {
                Console.WriteLine("Juhuslik nuber ongi 5");
            }




        }
    }
}
