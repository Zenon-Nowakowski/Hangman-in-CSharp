namespace Program2
{
    public class Puzzle
    {
        public static string phraseGen()
        {
            //get a random phrase from txt file 
            var lines = System.IO.File.ReadAllLines(@"phrases.txt");
            Random rnd = new Random();
            string phrase = lines[rnd.Next(lines.Length)];
            return phrase;
        }
        public static char[] createphraseArr(string phrase)
        {
            //convert phrase into array of letters
            var letters = phrase.ToCharArray();
            return letters;
        }
        public static char[] createGuessArr(char[] letters)
        {
            //set up array of guesses, fills on success
            var guessed = new char[letters.Length];
            //Fill guessed with defualt vals, '_' if space, fill with space
            for(int i = 0; i < letters.Length;i++)
            {
                if(letters[i] == ' ')
                {
                   guessed[i] = ' '; 
                }
                else
                {
                    guessed[i] = '_';
                }
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
            //compares the users input with the array of letters, if correct fills out guessed array, otherwise it returns false, and allows for lose of life
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
            //compares guessed array with letters array, if both are the exact same, returns true, aka. victory condition met
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