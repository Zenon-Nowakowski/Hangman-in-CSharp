namespace Program2
{
    public class Puzzle
    {
        public static char[] createCharArr(string word)
        {
            //Convert word into array of chars
            var chars = word.ToCharArray();
            //set up array of guesses, fills on success
            var guessed = new char[chars.Length];
            //Fill guessed with defualt vals
            for(int i = 0; i < chars.Length;i++)
            {
                guessed[i] = '_';
            }
            return guessed;
        }
        public static void PrintGuess(char[] guessed)
        {
            foreach(char c in guessed)
            {
                Console.Write(c);
            }
        }
    }
}