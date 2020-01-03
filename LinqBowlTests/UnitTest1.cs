using System;
using System.Collections.Generic;
using System.Linq;
using LinqBowl;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinqBowlTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var perfectGame = Enumerable.Range(1, 21).Select(i => 10).ToList();
            var finalScore = Game.ScoreGame(perfectGame);

            Assert.AreEqual(300, finalScore);
        }
    }
}
