namespace Program2
{
    public class Puzzle
    {
        public static string wordGen()
        {
            var lines = System.IO.File.ReadAllLines(@"words.txt");
            Random rnd = new Random();
            string word = lines[rnd.Next(lines.Length)];
            return word;
        }
        public static char[] createWordArr(string word)
        {
            //convert word into array of letters
            var letters = word.ToCharArray();
            return letters;
        }
        public static char[] createGuessArr(char[] letters)
        {
            //set up array of guesses, fills on success
            var guessed = new char[letters.Length];
            //Fill guessed with defualt vals
            for(int i = 0; i < letters.Length;i++)
            {
                guessed[i] = '_';
            }
            return guessed;
        }
        public static void PrintArr(char[] guessed)
        {
            foreach(char c in guessed)
            {
                Console.Write(c);
            }
        }
        public static bool check(char guess, char[] guessed, char[] letters)
        {
            var correct = false;
            for(int i = 0; i < letters.Length; i++)
            {
                if(guess == letters[i])
                {
                    guessed[i] = letters[i];
                    correct = true;
                }
            }
            return correct;
        }
        public static bool victoryCheck(char[] letters, char[] guessed)
        {
            bool victory = true;
            for(int i = 0; i < letters.Length; i++)
            {
                if(letters[i] != guessed[i])
                {
                    victory = false;
                }
            }
            return victory;
        }
    }
}