using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackjackClassLibrary.cards;
namespace BlackjackClassLibrary
{
    public class Deck
    {
        protected List<Card> _cards = new List<Card>();

        public Deck()
        {
            CreateAllCards();
        }

        public virtual void CreateAllCards()
        {
            foreach (CardSuit suit in Enum.GetValues(typeof(CardSuit)))
            {
                foreach (CardFace face in Enum.GetValues(typeof(CardFace)))
                {
                    _cards.Add(CardFactory.CreateCard(face, suit));
                }
            }
        }

        public Card Deal()
        {
            if (_cards.Count == 0)
            {
                CreateAllCards();
                Shuffle();
            }

            Card dealerPick = _cards.First();
            _cards.RemoveAt(0);
            return dealerPick;
        }

        public void Shuffle()
        {
            Random random = new Random();

            for (int i = 0; i < _cards.Count; i++)
            {
                int num = random.Next(0, _cards.Count);
                Card tempCard = _cards[i];
                _cards[i] = _cards[num];
                _cards[num] = tempCard;
            }

        }

        public void Print()
        {
            int x = 0, y = 0;
            Console.WriteLine(_cards.Count);

            for (int i = 0; i < _cards.Count; i++)
            {
                if (x > 110)
                {
                    y += 1;
                    x = 0;
                }

                _cards[i].Print(x, y);
                x += 10;


            }
        }
    }
}
