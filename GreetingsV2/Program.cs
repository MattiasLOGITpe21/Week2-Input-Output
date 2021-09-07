using System;

namespace GreetingsV2
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja eesnime
            //programm küsib kasutaja perekonna nime
            //programm tervitab kasutajat kasutades neid andmeid

            Console.WriteLine("Mis on sinu eesnimi");

            string Eesnimi = Console.ReadLine();

            Console.WriteLine("Mis on sinu perekonna nimi");

            string Perenimi = Console.ReadLine();

            Console.WriteLine($"Hello, {Eesnimi} {Perenimi}");

            Console.ReadLine();

        

        
            
        }
    }
}
