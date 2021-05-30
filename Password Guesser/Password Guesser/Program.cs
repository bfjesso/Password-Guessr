using System;

namespace Password_Guesser
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            int attempts = 0;
            
            char[] characters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            bool hasGuessedCorrect = false;

            Console.WriteLine("Type Password To Guess...");

            string password = Console.ReadLine();

            Console.Clear();

            string startTime = DateTime.Now.ToString("h:mm tt");

            while (!hasGuessedCorrect)
            {
                string guess = Guess();

                if(guess == password)
                {
                    hasGuessedCorrect = true;

                    string endTime = DateTime.Now.ToString("h:mm tt");

                    Console.Clear();
                    Console.WriteLine("Password Has Been Gueesed Correct: " + guess);
                    Console.WriteLine("It Took, " + attempts + " Attempts To Guess Correct Starting At " + startTime + ", Ending At, " + endTime + ".");

                    Console.ReadKey();

                    Environment.Exit(0);
                }
                else
                {
                    hasGuessedCorrect = false;
                    attempts++;
                }
            }


            string Guess()
            {
                string currentGuess = "";

                for (int i = 0; i < password.Length; i++)
                {
                    int character = rand.Next(0, characters.Length);
                    currentGuess += characters[character];
                }

                Console.WriteLine(currentGuess);

                return currentGuess;
            }
        }
    }
}
