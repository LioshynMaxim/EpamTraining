using Task5.NUnitTests;
using System;
using System.Net.Sockets;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Task5.Arrays;

namespace Task5.Test
{
    [TestClass]
    public class ArraysTests
    {
        [TestMethod]
        public void Method_OnlyOne_Exist()
        {
            //Arrange Act Assert (AAA)

            //Arrange
            var arr = new[] {1, 1, 1, 1, 1};
            int expected = 2;

            //Act
            Arrays arrays = new Arrays(arr);
            int actual = arrays.EqualityLeftAndRight();

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Method_SequencePositiveNumber_Exist()
        {
            var arr = new[] { 0, 1, 2, 3, 5, 6 };
            int expected = 4;

            Arrays arrays = new Arrays(arr);
            int actual = arrays.EqualityLeftAndRight();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Method_RandonNumber_Exist()
        {
            var arr = new[] { 1, 100, 50, -51, 1, 1 };
            int expected = 1;

            Arrays arrays = new Arrays(arr);
            int actual = arrays.EqualityLeftAndRight();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Method_RandonNumber_NotExist()
        {
            var arr = new[] { 1, 100, 50, -51, 1, 1, 1 };
            int expected = -1;

            Arrays arrays = new Arrays(arr);
            int actual = arrays.EqualityLeftAndRight();

            Assert.AreEqual(expected, actual);
        }
        
    }
}
