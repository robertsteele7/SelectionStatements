using System;
namespace SelectionStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int favoriteNumber = 13;
            
            Console.WriteLine("Guess the Favorite Number");
            int userGuess = int.Parse(Console.ReadLine());

            if (userGuess < favoriteNumber)
            {
                Console.WriteLine("Too Low!");
            }
            else if (userGuess > favoriteNumber)
            {
                Console.WriteLine("Too High");
            }
            else if (userGuess == favoriteNumber)
            {
                Console.WriteLine("You are Correct!!! Here's a COOKIE!");
            }
            else
            {
                Console.WriteLine("Nevermind");
            }
        }
    }
}
