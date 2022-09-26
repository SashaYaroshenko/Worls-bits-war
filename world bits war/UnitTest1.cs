namespace Solution
{
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;
    using ConsoleApp1;

    [TestFixture]
    public class SolutionTest
    {
        [Test]
        public void BasicTest()
        {
            Assert.AreEqual(Kata.BitsWar(new List<int> { 1, 5, 12 }), "odds win");
            Assert.AreEqual(Kata.BitsWar(new List<int> { 7, -3, 20 }), "evens win");
            Assert.AreEqual(Kata.BitsWar(new List<int> { 7, -3, -2, 6 }), "tie");
            Assert.AreEqual(Kata.BitsWar(new List<int> { -3, -5 }), "evens win");
            Assert.AreEqual(Kata.BitsWar(new List<int>()), "tie");
        }
    }
}