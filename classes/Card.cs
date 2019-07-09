using System;
using DeckOfCards.enums;

namespace DeckOfCards.classes
{
    public class Card
    {
        public string StringVal
        {
            get
            {
                return this.Value + " of " + this.Suit.ToString();
            }
        }
        public Suit Suit { get; set; }
        public int Value { get; set; }

        public Card(int value, Suit suit)
        {
            this.Value = value;
            this.Suit = suit;
        }
    }
}