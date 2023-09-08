using System;
namespace Uppgift_2._1
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Vilken stad kommer du ifrån?");
            string stad = Console.ReadLine();
            Console.WriteLine("Vad är ditt drömresemål?");
            string resemål = Console.ReadLine();

            Console.WriteLine("Hej " + stad + "bo. Jag hoppas att du får resa till " + resemål + ".");
            
            Console.ReadKey();
        }
    }
}