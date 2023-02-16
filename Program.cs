using System;
using System.IO;
using System.Xml.Serialization;

namespace Program2
{
    class Program
    {
        static void toXML(Player player)
        {
            XmlSerializer xs = new XmlSerializer(typeof(Player));  
            string path = "userrdata.xml";
            TextWriter txtWriter = new StreamWriter(@path);
            
            xs.Serialize(txtWriter, player);  
        
            txtWriter.Close();
        }
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
            Player player = new Player
            (
                user,
                DateTime.Today,
                0,
                0,
                0
            );
            //great user
            Console.WriteLine("Hello " + player.user + "!");
            Game.gameEngine(player);
            player.winpercent = player.gameswon / (player.gameslost+player.gameswon) * 100;
            Console.WriteLine(player.winpercent);
            Program.toXML(player);
        }
    }
}