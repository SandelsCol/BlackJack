using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJack
{
    public class Card
    {
        private string suit;
        private string symbol;
        private int score;
        private string color;

        public Card(string suit, string symbol)
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
                    if (score < 10)
                    {
                        value = 1;
                    }
                    else
                    {
                        value = 11;
                    }
                }
                else
                {
                    value = 10;
                }
            }

            this.score = value;
            
        }
 
        public string Suit
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
