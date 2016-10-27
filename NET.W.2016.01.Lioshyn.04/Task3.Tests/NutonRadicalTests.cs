using Task3;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Task3.Tests
{
    [TestClass]
    public class NutonRadicalTests
    {
        [TestMethod]
        public void Radical_2Form4_2()
        {
            NutonRadical nutonRadical = new NutonRadical(4, 2);
            var actual = nutonRadical.Radical();
            var expected = 2;

            Assert.AreEqual(actual,expected);
        }

        [TestMethod]
        public void Radical_2Form5_2236()
        {
            NutonRadical nutonRadical = new NutonRadical(5, 2);
            var actual = nutonRadical.Radical();
            var expected = 2.236;

            Assert.AreEqual(actual, expected);
        }

    }
}
