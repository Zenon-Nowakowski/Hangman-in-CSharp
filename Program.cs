using System;
using System.IO;

namespace Program2
{
    class Program
    {
        static void PrintGuess(char[] guessed)
        {
            foreach(char c in guessed)
            {
                Console.Write(c);
            }
        }
        static void Main(string[] args)
        {
            //vars and classes
            string user;
            bool cont = true;
            Random rnd = new Random();
            int tries = 6;
            char guess;

            //convert .txt into array 
            string[] lines = System.IO.File.ReadAllLines(@"words.txt");
            //Create user
            Console.WriteLine("Please input username: ");
            //get username, if none provided, set default: User
            user = Console.ReadLine();
            if(string.IsNullOrEmpty(user))
            {
                Console.WriteLine("Setting default name...");
                user = "User";
            }
            //great user
            Console.WriteLine("Hello " + user + "!");
            //set up of 'game engine'
            while(cont)
            {
                //Get a random word from lines array 
                string word = lines[rnd.Next(lines.Length)];
                //Convert word into array of chars
                char[] chars = word.ToCharArray();
                //set up array of guesses, fills on success
                char[] guessed = new char[chars.Length];
                //Fill guessed with defualt vals
                foreach(int i in guessed)
                {
                    guessed[i] = '_';
                }
                Program.PrintGuess(guessed);
                // Console.Write("Enter letter to guess: ");
                // guess = Console.ReadLine()[0];
                cont = false;
            }
        }
    }
}