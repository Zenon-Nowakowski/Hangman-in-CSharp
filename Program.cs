using System;
using System.IO;

namespace Program2
{
    class Program
    {
        //vars and classes declare
        static void Main(string[] args)
        {
            string user = Player.createUser();
            Game.gameEngine(user);
        }
    }
}