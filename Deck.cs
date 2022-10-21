using ArrayExtensions;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    internal class Deck
    {
        private List<Card> cards;
        private readonly Random random;

        public Deck()
        {
            random = new Random();

            Restock();
        }

        public void Restock()
        {
            cards = new List<Card>();

            string[] suits = { "Clover", "Diamonds", "Hearts", "Spades" };
            for (int i = 0; i < suits.Length; i++)
            {
                string suit = suits[i];

                for (int x = 1; x <= 13; x++)
                {
                    cards.Add(new Card(suit, x));
                }
            }
        }

        public Card DrawCard()
        {
            return cards.Extract(random.Next(cards.Count));
        }
    }
}
