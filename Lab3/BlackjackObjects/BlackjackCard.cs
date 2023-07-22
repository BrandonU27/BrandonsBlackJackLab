using BlackjackClassLibrary.cards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackClassLibrary
{
    public class BlackjackCard : Card
    {
        public int Value { get; set; }

        public BlackjackCard(CardFace fce, CardSuit sut) : base(fce, sut)
        {
            if (fce == CardFace.Ace)
                Value = 11;
            if (fce == CardFace.Two)
                Value = 2;
            if (fce == CardFace.Three)
                Value = 3;
            if (fce == CardFace.Four)
                Value = 4;
            if (fce == CardFace.Five)
                Value = 5;
            if (fce == CardFace.Six)
                Value = 6;
            if (fce == CardFace.seven)
                Value = 7;
            if (fce == CardFace.Eight)
                Value = 8;
            if (fce == CardFace.nine)
                Value = 9;
            if (fce == CardFace.Ten)
                Value = 10;
            if (fce == CardFace.Jack)
                Value = 10;
            if (fce == CardFace.Queen)
                Value = 10;
            if (fce == CardFace.King)
                Value = 10;
        }
    }
}
