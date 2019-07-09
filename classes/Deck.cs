using System;
using System.Collections.Generic;
using System.Linq;
using DeckOfCards.enums;

namespace DeckOfCards.classes
{
    public class Deck
    {
        // fields
        private Random rng;

        // properties
        public List<Card> Cards { get; private set; }

        // constructor
        public Deck()
        {
            rng = new Random();
            this.Cards = new List<Card>();
            AddDeck();
        }

        // add standard 52 card deck
        private void AddDeck()
        {
            foreach (Suit suit in Enum.GetValues(typeof(Suit)))
            {
                for (var i = 1; i <= 13; i++)
                {
                    this.Cards.Append(new Card(i, suit));
                }
            }
        }

        // fisher-yates shuffle
        public void Shuffle()
        {
            int n = this.Cards.Count;
            for (int i = 0; i < n; i++)
            {
                int r = i + rng.Next(n - i);
                var t = this.Cards[r];
                this.Cards[r] = this.Cards[i];
                this.Cards[i] = t;
            }
        }

        // removes the top card from the deck and returns it
        public Card DrawTopCard()
        {
            var card = this.Cards.Last();
            this.Cards.RemoveAt(this.Cards.Count - 1);
            return card;
        }

        // reset back to 52-card deck
        public void Reset()
        {
            this.Cards = new List<Card>();
            AddDeck();
        }
    }
}