using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJack
{
    public class User
    {
        private List<Card> hand;

        public void Addcard(Card c)
        {
            hand.Add(c);
        }

        public List<Card> Hand { get => hand; set => hand = value; }
    }
}
