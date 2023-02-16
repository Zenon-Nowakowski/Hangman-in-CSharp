namespace Program2
{
    public class Player
    {
        public static string createUser()
        {
            string user;
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
            return user;
        }
    }
}