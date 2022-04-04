using System;
using System.Collections.Generic;
using System.Text;

namespace Uno_
{
    class Hand : GameManager
    {


        public static void createHand()
        {
            foreach(Player player in playerslist)
            {
                for (int i = 0; i < 7; i++)
                {
                    player.Hand.AddRange(cards);


                }


            }


        }
    }
}

           





    

