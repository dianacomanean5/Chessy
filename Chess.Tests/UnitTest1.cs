using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Chess.clase;
using System.Drawing;

namespace Chess.Tests
{
    [TestClass]
    public class TuraTests
    {
        [TestMethod]
        public void Tura_albimage()
        {
              Tura tip = new Tura(true);
            Image expected_image = Properties.Resources.chess_piece_2_white_rook;
            Assert.AreEqual(expected_image, tip.image);


        }
        [TestMethod]
        public void Tura_tipalb()
        {
            Tura tura = new Tura(true);
            int tip_expected = 7;
            Assert.AreEqual(tip_expected, tura.tip.id);
        }
        [TestMethod]
        public void Tura_blackimage()
        {
            Tura tip = new Tura(false);
            Image expected_image = Properties.Resources.chess_piece_2_black_rook;
            Assert.AreEqual(expected_image, tip.image);


        }
        [TestMethod]
        public void Tura_tipblack()
        {
            Tura tura = new Tura(false);
            int tip_expected = 8;
            Assert.AreEqual(tip_expected, tura.tip.id);
        }
    }
}
