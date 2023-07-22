using System;
using PG2Input;
using BlackjackClassLibrary.cards;
using BlackjackClassLibrary;
using System.Collections.Generic;
using FullSailCasino;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sample hands with menu

            string[] menu = new string[] { "1. Play Blackjack", "2. Shuffle and Show Deck", "3. Sample Hands", "4. Exit" };
            bool inmenu = true;
            Deck deck = new Deck();

            //THE SAMPLE BLACKJACK HANDS AND DECKS

            BlackjackDeck blackDeck = new BlackjackDeck();
            BlackjackHand user = new BlackjackHand();
            BlackjackHand dealer = new BlackjackHand(true);

            BlackjackGame game = new BlackjackGame();
            bool playagain = false;
            string[] playag = new string[] { "1. Yes", "2. No" };

            Console.OutputEncoding = System.Text.Encoding.Unicode;
            while (inmenu)
            {
                Console.Clear();
                Input.ReadChoice("Choice?", menu, out int selection);
                Console.Clear();

                switch (selection)
                {
                    case 1:
                        do
                        {
                            game.Playround();
                            game.DrawWins();

                            Input.ReadChoice("Play Again?", playag, out int play);
                            switch (play)
                            {
                                case 1:
                                    playagain = true;
                                    break;
                                case 2:
                                    playagain = false;
                                    break;
                            }
                        } while (playagain);
                        break;
                    case 2:
                        deck.Shuffle();
                        deck.Print();
                        ExitMessage();
                        break;
                    case 3:
                        blackDeck.CreateAllCards();
                        for (int i = 0; i < 2; i++)
                        {
                            user.AddCard(blackDeck.Deal());
                            dealer.AddCard(blackDeck.Deal());
                        }
                        user.Print(7, 1);
                        dealer.Print(7, 4);
                        Console.WriteLine();
                        ExitMessage();
                        break;
                    case 4:
                        inmenu = false;
                        ExitMessage();
                        break;
                }

            }

        }

        static void ExitMessage()
        {
            Console.WriteLine("\nPress any button to continue...");
            Console.ReadKey();
        }
        
    }
}
