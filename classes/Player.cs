using System;
using System.Collections.Generic;

namespace DeckOfCards.classes
{
    public class Player
    {
        // properties
        public string Name { get; private set; }
        public List<Card> Hand { get; private set; }

        // constructor
        public Player(string name)
        {
            this.Name = name;
            this.Hand = new List<Card>();
        }

        // draw a card from the deck and add to hand
        public void DrawCard(Deck cardDeck)
        {
            this.Hand.Add(cardDeck.DrawTopCard());
        }

        // discard a card at the given index
        public Card DiscardCard(int index)
        {
            if (index >= this.Hand.Count)
            {
                return null;
            }
            else
            {
                var card = this.Hand[index];
                this.Hand.RemoveAt(index);
                return card;
            }
        }
    }
}