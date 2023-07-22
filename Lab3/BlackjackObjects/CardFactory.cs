using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackjackClassLibrary.cards;

namespace BlackjackClassLibrary
{
    public static class CardFactory
    {

        public static Card CreateCard(CardFace face, CardSuit suit)
        {
            return new Card(face, suit);
        }

        public static Card CreateBlackjackCard(CardFace face, CardSuit suit)
        {
            return new BlackjackCard(face, suit);
        }

    }
}
