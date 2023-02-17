namespace Program2
{
    public class Game 
    {
        public DateTime date;
        public string phrase;

        //constructor 
        public Game(DateTime date, string phrase)
        {
            this.date = date; 
            this.phrase = phrase;
        }
        //xml export constructor
        public Game()
        {}
    }
    //all characteristics of a player 
    public class Player
    {
        public int life = 6; 
        public string user;
        public int gameswon;
        public int gameslost;
        public decimal winpercent;
        //constructor 
        public Player(string user, int gameswon, int gameslost, decimal winpercent)
        {
            this.user = user; 
            this.gameswon = gameswon;
            this.gameslost = gameslost;
            this.winpercent = winpercent;
        }
        public void calculateWin(decimal top, decimal bottom, Player player)
        {
            player.winpercent = top / bottom * 100;
        }
        //xml export constructor
        public Player()
        {}
    }
}