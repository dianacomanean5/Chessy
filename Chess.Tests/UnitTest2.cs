using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Chess.clase;
using System.Drawing;

namespace Chess.Tests
{
    [TestClass]
    public class CalTests
    {
        [TestMethod]
        public void Cal_trueimage()
        {
            Cal tip = new Cal(true);
            Image expected_image = Properties.Resources.chess_piece_2_white_knight;
            Assert.AreEqual(expected_image, tip.image);
        }
        [TestMethod]
        public void Cal_tipalb()
        {
            Cal cal = new Cal(true);
            int tip_expected = 1;
            Assert.AreEqual(tip_expected, cal.tip.id);
        }
        [TestMethod]
        public void Cal_blackimage()
        {
            Cal tip = new Cal(false);
            Image expected_image = Properties.Resources.chess_piece_2_black_knight;
            Assert.AreEqual(expected_image, tip.image);


        }
        [TestMethod]
        public void Cal_tipblack()
        {
            Cal cal = new Cal(false);
            int tip_expected = 2;
            Assert.AreEqual(tip_expected, cal.tip.id);
        }
    }
}
