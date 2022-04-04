using System;
using System.Collections.Generic;
using System.Text;

namespace Uno_
{
    class GameManager
    {
        public static List<Player> playerslist = new List<Player>();
        public static List<Card> cards = new List<Card>();

        public static void Initialise()
        {
            Player.GetNamesOfPlayers();
            Deck.createDeck();
            Deck.Shuffle();
            Hand.createHand();
            DiscardPile.createDiscardPile();

        }





    }
}
