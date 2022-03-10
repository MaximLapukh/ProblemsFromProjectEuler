using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem54.Model
{
    public class Card
    {
        public Master master { get; set; }
        public Suit suit { get; set; }
        public Card()
        {

        }
        public Card(Master master, Suit suit)
        {
            this.master = master;
            this.suit = suit;
        }
        public static Card ToCard(string key)
        {
            throw new NotImplementedException();
        }
    }
}
