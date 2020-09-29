using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJack
{
    public class Card
    {
        private char suit;
        private string symbol;
        private int score;
        private string color;

        public Card(char suit, string symbol)
        {
            this.suit = suit;
            this.symbol = symbol;

            if(suit.Equals("Corazón") || suit.Equals("Diamante"))
            {
                this.color = "Black";
            }
            else
            {
                this.color = "Red";
            }

            int value;

            try
            {
                value = Convert.ToInt32(symbol);

            }catch (FormatException)

            {
                if (symbol == "A")
                {
                    value = 11;
                }
                else
                {
                    value = 1;
                }
            }

            this.score = value;
            
        }
 
        public char Suit
        {
            get { return suit; }
            set { suit = value; } 
        }

        public string Symbol
        {
            get { return symbol; }
            set { symbol = value; }
        }

        public int Score
        {
            get { return score; }
            set { score = value; }
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

    }
}
