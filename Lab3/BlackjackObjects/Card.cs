using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackClassLibrary.cards
{
    public class Card
    {
        
        public CardSuit Suit { get; private set; }
        public CardFace Face { get; private set; }

        public Card(CardFace fce, CardSuit sut)
        {
            Face = fce;
            Suit = sut;
        }

        public void Print(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.BackgroundColor = ConsoleColor.White;
            if(Suit == CardSuit.Clubs || Suit == CardSuit.Spades)
                Console.ForegroundColor = ConsoleColor.Black;
            else
                Console.ForegroundColor = ConsoleColor.Red;

            switch (Face)
            {
                case CardFace.Ace:
                    Console.Write("  A  ");
                    break;
                case CardFace.Two:
                    Console.Write("  2  ");

                    break;
                case CardFace.Three:
                    Console.Write("  3  ");

                    break;
                case CardFace.Four:
                    Console.Write("  4  ");

                    break;
                case CardFace.Five:
                    Console.Write("  5  ");

                    break;
                case CardFace.Six:
                    Console.Write("  6  ");

                    break;
                case CardFace.seven:
                    Console.Write("  7  ");

                    break;
                case CardFace.Eight:
                    Console.Write("  8  ");

                    break;
                case CardFace.nine:
                    Console.Write("  9  ");

                    break;
                case CardFace.Ten:
                    Console.Write(" 10  ");

                    break;
                case CardFace.Jack:
                    Console.Write("  J  ");

                    break;
                case CardFace.Queen:
                    Console.Write("  Q  ");

                    break;
                case CardFace.King:
                    Console.Write("  K  ");

                    break;
            }


            switch (Suit)
            {
                case CardSuit.Spades:
                    Console.Write("♠  ");
                    break;
                case CardSuit.Hearts:
                    Console.Write("♥  ");
                    break;
                case CardSuit.Clubs:
                    Console.Write("♣  ");
                    break;
                case CardSuit.Diamonds:
                    Console.Write("♦  ");
                    break;
            }
            Console.ResetColor();
        }

        

    }
}
