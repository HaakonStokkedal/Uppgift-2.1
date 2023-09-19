using System;

namespace uppgift_2._1
{

    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Vilken är din favoritbok?");
            string bok = Console.ReadLine();
            Console.WriteLine("Din favorit bok är " + bok + ".");

            Console.ReadKey();
        }
    }
}