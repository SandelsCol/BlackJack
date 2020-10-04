using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack
{   
    public class Dealer : User 
    {
        private List<Card> deck;

        public Dealer()
        {
            Generate();
        }

        public void Generate()
        {
            deck = new List<Card>();
            Hand = new List<Card>();

            string[] suit = { "♥", "♦", "♣", "♠" };
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

        public void Randomize()
        {
            Random n = new Random();
            int pos;
            Card w;
            for (int i = 0; i < 52; i++)
            {
                pos = n.Next(51);

                w = deck[i];
                deck[i] = deck[pos];
                deck[pos] = w;
            }

        }

        public Card Deal()
        {
            Card c = this.deck.First();
            this.deck.Remove(c);
            return c;
        }
        public void Init()
        {
            Addcard(Deal()); // Hand.add(cx)
            Addcard(Deal());
        }
        public List<Card> Deck { get => deck; set => deck = value; }
    }
}
