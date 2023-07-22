using BlackjackClassLibrary;
using PG2Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullSailCasino
{
    public class BlackjackGame
    {
        BlackjackHand _dealer;
        BlackjackHand _player;
        BlackjackDeck _deck;

        int _playerWins = 0;
        int _dealerWins = 0;

        bool tie = false;

        public void Playround()
        {
            _deck = new BlackjackDeck();
            if(_deck == null)
                _deck.CreateAllCards();
            _dealer = new BlackjackHand(true);
            _player = new BlackjackHand();

            DealInitialCards();
            DrawTable();

            if (_player.Score != 21)
            {
                PlayersTurn();
                DealersTurn();
            }
            DeclareWinner();
        }

        public void DealInitialCards()
        {
            for (int i = 0; i < 2; i++)
            {
                _player.AddCard(_deck.Deal());
                _dealer.AddCard(_deck.Deal());
            }
        }

        public void PlayersTurn()
        {
            string[] hitStand = new string[] { "1. Hit", "2. Stand" };

            do
            {
                Input.ReadChoice("Hit or Stand?", hitStand , out int selection);
                if (selection == 2)
                    break;
                if(selection == 1)
                {
                    _player.AddCard(_deck.Deal());
                }
                DrawTable();


            } while (_player.Score < 21);
            DrawTable();

        }

        public void DealersTurn()
        {
                _dealer.isDealer = false;

            if (_player.Score > 21)
            {
                DrawTable();
            }
            else
            {
                while (_dealer.Score < 17)
                {
                    _dealer.AddCard(_deck.Deal());
                }
            }
            DrawTable();
        }

        public void DeclareWinner()
        {
            int p = _player.Score;
            int d = _dealer.Score;

            if(p > 21)
            {
                Console.WriteLine("\n\nSorry the dealer won :(");
                _dealerWins++;
            }
            else
            {
                if(d > 21)
                {
                    Console.WriteLine("\n\nYou were able to beat the house today :)");
                    _playerWins++;
                }
                else
                {
                    if(p > d)
                    {
                        Console.WriteLine("\n\nYou were able to beat the house today :)");
                        _playerWins++;
                    }
                    else
                    {
                        if (d > p)
                        {
                            Console.WriteLine("\n\nSorry the dealer won :(");
                            _dealerWins++;
                        }
                        else
                        {
                            tie = true;
                        }
                    }
                }
            }
        }

        public void DrawTable()
        {
            Console.Clear();
            Console.WriteLine("----------Your Hand----------\n");
            _player.Print(7, 1);
            Console.WriteLine("\n----------Dealer's Hand----------\n");
            _dealer.Print(7, 4);
            Console.WriteLine();
        }

        public void DrawWins()
        {
            Console.WriteLine("Lets See who's winning\n-------------------------------------------------");
            if (tie)
            {
                Console.WriteLine("TIE GAME");
                tie = false;
            }
            Console.WriteLine($"Dealer's wins: {_dealerWins}");
            Console.WriteLine($"Player's wins: {_playerWins}\n");
        }
    }
}
