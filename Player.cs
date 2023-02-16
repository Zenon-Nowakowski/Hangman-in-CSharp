namespace Program2
{
    public class Player
    {
        public int life = 6; 
        public string user;
        public DateTime date;
        public int gameswon;
        public int gameslost;
        public decimal winpercent;
        public Player(string user, DateTime date, int gameswon, int gameslost, decimal winpercent)
        {
            this.user = user; 
            this.date = date; 
            this.gameswon = gameswon;
            this.gameslost = gameslost;
            this.winpercent = winpercent;
        }
        public Player()
        {}
    }
}