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
        

        [TestMethod()]
        public void Equals_TwoLongestString_abcdfghjklmnsvxz()
        {
            string str1 = "aksjfhdladkjfhgkfldalskdjfhghfjdkdlslaksjdhfk";
            string str2 = "zmxncbcvgdbcjnzbcvxmnbvcxzahsjdjfhkjhhasdghbhjcbzhjzsvdgzsdhzcbnhgvsd";
            ConCatSort conCatSort = new ConCatSort(str1, str2);

            var expected = "abcdfghjklmnsvxz";
            var actual = conCatSort.Longest();

            Assert.AreEqual(expected,actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Exception_AllNullString_Exist()
        {
            new ConCatSort(null, null);
        }

       
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Exception_OneEmptyString_Exist()
        {
            new ConCatSort("mmm", null);
        }

        [TestMethod]
        public void Equals_TwoLongestStringWithOwerSymbols_abcdfghjklmnsvxz()
        {
            string str1 = ".;.;.;.;.;.;.;.;.;.;.;.;.;.;.;.;.;.;;.;.;._=,jsdahlfjgdsgfha's;sldkfjhgdhfjsl";
            string str2 = "zmxncbcvgdbcjnzbcvxmnbvcx;zahsjdjfhkjhhasdghbhjcbzhjzsvdgzsdhzcbnhgvsd";
            ConCatSort conCatSort = new ConCatSort(str1, str2);

            var expected = "abcdfghjklmnsvxz";
            var actual = conCatSort.Longest();

            Assert.AreEqual(expected, actual);
        }

    }
}