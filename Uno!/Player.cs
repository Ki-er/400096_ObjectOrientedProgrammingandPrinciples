using System;
using System.Collections.Generic;
using System.Text;

namespace Uno_
{
    public class Player
    {
        protected string mName { get; set; }
        protected int mID { get; set; }
        public List<Player> Hand = new List<Player>();


        public static int GetNamesOfPlayers()
        {
            
            int pNumberOfPlayers = Program.GetNumberFromUserInRange("How Many Players Are There?", 2, 4);
            Console.Clear();


            for (int i = 0; i < pNumberOfPlayers; i++)
            {
                Player players = new Player();
                players.mID = i + 1;
                Console.WriteLine("Player " + players.mID + " What is your name?");
                players.mName = Console.ReadLine();
                players.mID = i + 1;
                GameManager.playerslist.Add(players);

            }

            return pNumberOfPlayers;
        }






    }
}
