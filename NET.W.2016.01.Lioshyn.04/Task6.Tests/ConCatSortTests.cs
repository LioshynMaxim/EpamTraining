using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6.Tests
{
    [TestClass()]
    public class ConCatSortTests
    {
        public static class ExceptionAssert
        {
            public static void ThrowsInstanceOf<T>(Action action)
            {
                try
                {
                    action();
                }
                catch (Exception xcp)
                {
                    if (xcp is T)
                    {
                        return;
                    }

                    throw new AssertFailedException(
                        String.Format(
                            "Test action threw exception {0}, but exception {1} was expected.",
                            xcp.GetType().FullName,
                            typeof(T).FullName));
                }

                throw new AssertFailedException(
                    String.Format(
                        "Test action did not throw expected exception {0}.",
                        typeof(T).FullName));
            }
        }

        [TestMethod()]
        public void Equals_TwoLongestString_abcdfghjklmnsvxz()
        {
            string str1 = "aksjfhdladkjfhgkfldalskdjfhghfjdkdlslaksjdhfk";
            string str2 = "zmxncbcvgdbcjnzbcvxmnbvcxzahsjdjfhkjhhasdghbhjcbzhjzsvdgzsdhzcbnhgvsd";
            ConCatSortClass conCatSort = new ConCatSortClass(str1, str2);

            var expected = "abcdfghjklmnsvxz";
            var actual = conCatSort.Longest();

            Assert.AreEqual(expected,actual);
        }

        [TestMethod]
        public void Exception_AllNullString_Exist()
        {
            ExceptionAssert.ThrowsInstanceOf<ArgumentException>(() => new ConCatSortClass(null,null));
        }

        [TestMethod]
        public void Exception_OneNullString_Exist()
        {
            ExceptionAssert.ThrowsInstanceOf<ArgumentException>(() => new ConCatSortClass("mmm", null));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Exception_OneEmptyString_Exist()
        {
            new ConCatSortClass("mmm", null);
        }

        [TestMethod]
        public void Equals_TwoLongestStringWithOwerSymbols_abcdfghjklmnsvxz()
        {
            string str1 = ".;.;.;.;.;.;.;.;.;.;.;.;.;.;.;.;.;.;;.;.;._=,jsdahlfjgdsgfha's;sldkfjhgdhfjsl";
            string str2 = "zmxncbcvgdbcjnzbcvxmnbvcx;zahsjdjfhkjhhasdghbhjcbzhjzsvdgzsdhzcbnhgvsd";
            ConCatSortClass conCatSort = new ConCatSortClass(str1, str2);

            var expected = "abcdfghjklmnsvxz";
            var actual = conCatSort.Longest();

            Assert.AreEqual(expected, actual);
        }

    }
}