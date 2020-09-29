using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJack
{   
    public class Dealer
    {
        private List<Card> deck;

        public Dealer()
        {
            Generate();
        }

        public void Generate()
        {
            deck = new List<Card>();

            string[] suit = { "Corazón", "Trebol", "Picas", "Diamante" };
            string[] symbol = { "A", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };

            foreach (string su in suit)
            {
                foreach(string sy in symbol)
                {
                    Card c = new Card(su, sy);
                    deck.Add(c);
                }
            }
        }

        public List<Card> Deck { get => deck; set => deck = value; }
    }
}
