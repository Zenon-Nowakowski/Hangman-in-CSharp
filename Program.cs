using System;
using System.IO;

namespace Program2
{
    class Program
    {
        //vars and classes declare
        static void Main(string[] args)
        {
            //Create user
            Console.WriteLine("Please input username: ");
            //get username, if none provided, set default: User
            var user = Console.ReadLine();
            if(string.IsNullOrEmpty(user))
            {
                Console.WriteLine("Setting default name...");
                user = "NoNameJane";
            }
            //define player class, class instantiations
            Player player = new Player
            (
                user,
                0,
                0,
                0
            );
            //create user
            Console.WriteLine("Hello " + player.user + "!");
            Play.gameEngine(player);
        }
    }
}