namespace Program2
{
    public class Player
    {
        int life = 6; 
        string user;
        public static string createUser()
        {
            Player player = new Player();
            //Create user
            Console.WriteLine("Please input username: ");
            //get username, if none provided, set default: User
            player.user = Console.ReadLine();
            if(string.IsNullOrEmpty(player.user))
            {
                Console.WriteLine("Setting default name...");
                player.user = "User";
            }
            //great user
            Console.WriteLine("Hello " + player.user + "!");
            return player.user;
        }
    }
}