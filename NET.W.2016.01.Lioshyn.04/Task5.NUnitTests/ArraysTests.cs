using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using static Task5.Arrays;
using NUnit.Framework.Interfaces;
using NUnit.Framework.Internal;

namespace Task5.NUnitTests
{
    [TestFixture()]
    public class ArraysTests
    {
        [Test()]
        public void Method_OnlyOne_Exist(int u)
        {
            var arr = new[] { 1, 1, 1, 1, 1 };
            int expected = 2;

            Arrays arrays = new Arrays(arr);
            int actual = arrays.EqualityLeftAndRight();

            Assert.AreEqual(expected, actual);
           
        }

        
    }
}
