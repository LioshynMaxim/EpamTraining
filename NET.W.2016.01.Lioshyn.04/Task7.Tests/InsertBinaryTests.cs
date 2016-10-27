using Task7;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Task7.Tests
{
    [TestClass]
    public class InsertBinaryTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            InsertBinary insertBinary = new InsertBinary(8, 15, 0, 0);
            
            var expected = insertBinary.Insertion();
            var actual = 9;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void TestMethod2()
        {
            InsertBinary insertBinary = new InsertBinary(0, 15, 30, 30);

            var expected = insertBinary.Insertion();
            var actual = 1073741824;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void TestMethod3()
        {
            InsertBinary insertBinary = new InsertBinary(0, 15, 0, 30);

            var expected = insertBinary.Insertion();
            var actual = 15;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void TestMethod4()
        {
            InsertBinary insertBinary = new InsertBinary(15, -15, 4, 4);

            var expected = insertBinary.Insertion();
            var actual = 31;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void TestMethod5()
        {
            InsertBinary insertBinary = new InsertBinary(15, int.MaxValue, 3, 5);

            var expected = insertBinary.Insertion();
            var actual = 63;

            Assert.AreEqual(expected, actual);
        }
    }
}
