using System;
using System.Collections.Generic;

namespace DeckOfCards.classes
{
    public class Player
    {
        public string Name { get; private set; }
        public List<Card> Hand { get; private set; }

        public Player()
        {

        }

        public void DrawCard(Deck cardDeck)
        {
            this.Hand.Add(cardDeck.DrawTopCard());
        }

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