namespace Program2
{
    public static class Game
    {
        public static bool promp(Player player)
        {
            bool cont;
            char input = Console.ReadLine()[0];
            if(input == 'y' || input == 'Y')
            {
                player.life = 6;
                cont = true;
            }
            else 
            {
                cont = false;
            }
            return cont;
        }
        public static void gameEngine(Player player)
        {
            //vars and class declare
            Boolean cont = true;
            //convert .txt into array 
            //set up of 'game engine'
            while(cont)
            {
                //Initialize game
                var word = Puzzle.wordGen();
                char[] letters = Puzzle.createWordArr(word);
                char[] guessed = Puzzle.createGuessArr(letters);
                char[] wrong = new char[6];
                //play
                while(player.life != 0 && Puzzle.victoryCheck(letters,guessed) == false)
                {
                    //Ask for user input,  
                    Console.WriteLine("-------------------------------");
                    Console.WriteLine("Guess this word: ");
                    Puzzle.PrintArr(guessed);
                    Console.WriteLine();
                    Console.Write("Wrong inputs so far: ");
                    Puzzle.PrintArr(wrong);
                    Console.WriteLine();
                    Console.Write("Enter letter to guess: ");
                    char guess = Console.ReadLine()[0];
                    if(Puzzle.check(guess, guessed, letters) == false)
                    {
                        player.life -= 1;
                        wrong[player.life] = guess;
                    }
                }
                if(player.life == 0)
                {
                    player.gameslost += 1;
                    Console.WriteLine("Looks like you lost, care to play again? (Y/N): ");
                    cont = Game.promp(player);
                }
                else
                {
                    player.gameswon += 1;
                    Console.WriteLine("Looks like you won! Care to play again? (Y/N): ");
                    cont = Game.promp(player);
                }
            }
        }
    }
}