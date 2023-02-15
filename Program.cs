using System;
using System.IO;

namespace Program2
{
    class Program
    {
        static void Main(string[] args)
        {
            //vars and classes
            string user;
            //try catch for input file
            try
            {
                string[] lines = System.IO.File.ReadAllLines(@"words.txt");
            }
            catch(FileNotFoundException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            Console.WriteLine("Please input username: ");
            //get username, if none provided, set default: User
            user = Console.ReadLine();
            if(string.IsNullOrEmpty(user))
            {
                Console.WriteLine("Setting default name...");
                user = "User";
            }
            Console.WriteLine("Hello ", user, "!");
        }
    }
}