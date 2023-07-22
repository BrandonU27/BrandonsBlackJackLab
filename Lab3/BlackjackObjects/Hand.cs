using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackjackClassLibrary.cards;

namespace BlackjackClassLibrary
{
    public class Hand
    {
        protected List<Card> _cards = new List<Card>();

        public virtual void AddCard(Card card)
        {
            _cards.Add(card);
        }

        public virtual void Print(int x, int y)
        {
            foreach (var item in _cards)
            {
                item.Print(x, y);
                x += 10;
            }

        }
    }
}
