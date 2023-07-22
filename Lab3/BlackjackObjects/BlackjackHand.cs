using BlackjackClassLibrary.cards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackClassLibrary
{
    public class BlackjackHand : Hand
    {
        public int Score { get; private set; }
        public bool isDealer { get; set; }

        public BlackjackHand(bool dealer = false)
        {
            isDealer = dealer;
        }
        public override void AddCard(Card card)
        {
            base.AddCard(card);
            BlackjackCard newCard = (BlackjackCard)card;
            Score += newCard.Value;

            if(Score > 21)
            {
                foreach (BlackjackCard item in _cards)
                {
                    if(item.Value == 11)
                    {
                        item.Value = 1;
                        Score = Score - 10;
                    }
                    if (Score < 21) break;
                    
                }
            }
        }
        public override void Print(int x, int y)
        {
            if (isDealer == true)
            {
                Console.BackgroundColor = ConsoleColor.Magenta;
                Console.SetCursorPosition(x, 4);
                Console.Write("        ");
                Console.ResetColor();
                for (int i = 1; i < _cards.Count; i++)
                {
                    x += 10;
                    _cards[1].Print(x, y);
                }
                Console.Write("   ??");
            }
            else
            {
                base.Print(x, y);
                Console.Write("   " + Score);
            }
        }
    }
}
