using Microsoft.VisualStudio.TestTools.UnitTesting;
using BlackjackClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackClassLibrary.Tests
{
    [TestClass()]
    public class BlackjackHandTests
    {
        [TestMethod()]
        public void AddCardTest()
        {
            BlackjackHand test = new BlackjackHand();
            BlackjackCard Ace = new BlackjackCard(CardFace.Ace, CardSuit.Spades);
            BlackjackCard CARD = new BlackjackCard(CardFace.Eight, CardSuit.Hearts);

            test.AddCard(Ace);
            test.AddCard(CARD);

            Assert.AreEqual(test.Score, 19);
        }
    }
}