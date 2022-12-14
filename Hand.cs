using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    internal class Hand
    {
        public List<Card> cards;
        public Hand()
        {
            cards = new List<Card>();
        }

        public int Value
        {
            get { 
                int sum = cards.Sum(x => x.value == 1 ? 11 : x.value);

                int aces = cards.Sum(x => x.name == "Ace" ? 1 : 0);

                while (sum > 21)
                {
                    if (aces > 0)
                    {
                        aces--;
                        sum -= 10;
                    } else
                    {
                        break;
                    }
                }

                return sum;
            }
        }

        public void AddCard(Card card)
        {
            cards.Add(card);
        }

        public bool IsOver()
        {
            return Value > 21;
        }

        public string OutputHand()
        {
            string output = "";

            cards.ForEach(card => output += $"{card.name} of {card.suit} \n");

            output += "\n";
            output += $"Total value of hand: {Value}";
            output += "\n";

            return output;
        }
    }
}
