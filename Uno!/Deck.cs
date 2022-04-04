using System;
using System.Collections.Generic;
using System.Text;

namespace Uno_
{



     class Deck : Card
    {
        private static Random ShuffleRNG = new Random();




         public static void createDeck()
        {
            foreach (Colours colour in Enum.GetValues(typeof(Colours)))
            {
                if (colour == Colours.red || colour == Colours.yellow || colour == Colours.green || colour == Colours.blue)
                {

                    for(int i = 0;i < 9; i++ )
                    {

                        if (i  == 0)
                        {
                            GameManager.cards.Add(new Deck() { Colour = colour, Number = i });

                        }

                        if (i != 0)
                        {
                            GameManager.cards.Add(new Deck() { Colour = colour, Number = i });
                            GameManager.cards.Add(new Deck() { Colour = colour, Number = i });
                        }

                    }


                    
                }
            }
        }

        public static void Shuffle()
        {
            int CardCounter = GameManager.cards.Count;
            while (CardCounter > 1)
            {
                CardCounter--;
                int k = ShuffleRNG.Next(CardCounter + 1);
                Card value = GameManager.cards[k];
                GameManager.cards[k] = GameManager.cards[CardCounter];
                GameManager.cards[CardCounter] = value;
            }
        }


    }








}


        


       



    
 