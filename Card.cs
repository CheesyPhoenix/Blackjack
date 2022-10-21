using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{

    internal class Card
    {
        public string suit;
        public int value;
        public string name;

        public Card(string suit, int value)
        {
            this.suit = suit;
            this.value = Math.Clamp(value, 1, 10);

            string[] cardNames = { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Knight", "Queen", "King" } ;
            name = cardNames[Math.Clamp(value - 1, 0, cardNames.Length)];
        }
    }
}
