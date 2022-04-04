using System;
using System.Collections.Generic;
using System.Text;

namespace Uno_
{
     class Card
    {

         protected  enum Colours
        {
            red,
            green,
            blue,
            yellow,
            allcolours
        }


        protected int Number { get; set; }


        protected Colours Colour { get; set; }
    }
}
