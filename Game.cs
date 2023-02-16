namespace Program2
{
    public class Game
    {
        public static void gameEngine(string user)
        {
            //vars and class declare
            Boolean cont = true;
            Random rnd = new Random();
            //convert .txt into array 
            string[] lines = System.IO.File.ReadAllLines(@"words.txt");
            //set up of 'game engine'
            while(cont)
            {
                //Get a random word from lines array 
                string word = lines[rnd.Next(lines.Length)];
                char[] guessed = Puzzle.createCharArr(word);
                Puzzle.PrintGuess(guessed);
                // Console.Write("Enter letter to guess: ");
                // guess = Console.ReadLine()[0];
                cont = false;
            }
        }
    }
}