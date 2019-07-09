using System;
using DeckOfCards.enums;

namespace DeckOfCards.classes
{
    public class Card
    {
        // properties
        public string StringVal
        {
            get
            {
                // returns a string name of card (e.g. 2 of Clubs)
                return this.Value + " of " + this.Suit.ToString();
            }
        }
        public Suit Suit { get; set; }
        public int Value { get; set; }


        // Constructor
        public Card(int value, Suit suit)
        {
            this.Value = value;
            this.Suit = suit;
        }
    }
}