using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem54.Model
{
    public class Player
    {
        public int index { get; set; }
        public List<Card> cards { get; set; }
        public List<int> GetScore()
        {
            var res = new List<int>();

            foreach (var card in cards)
            {
                var temp = HighestCard(card);
                if (temp > 0)
                {
                    res.Add(temp);
                }
                OnePair(card);
                if (temp > 0)
                {
                    res.Add(temp);
                }
                TwoPair(card);
                if (temp > 0)
                {
                    res.Add(temp);
                }
            }
            //res.Sort();
            return res;
        }
        private int HighestCard(Card card)
        {
            return 0;
        }
        private int OnePair(Card card)
        {
            return 0;
        }
        private int TwoPair(Card card)
        {
            return 0;
        }
    }
}
