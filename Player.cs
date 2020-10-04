using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJack
{
    class Player : User
    {
        public void Init(Card c1, Card c2)
        {
            Addcard(c1); // Hand.add(cx)
            Addcard(c2);
        }
    }
}
