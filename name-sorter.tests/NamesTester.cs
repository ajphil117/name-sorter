using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using name_sorter;

namespace name_sorter.tests
{
    [TestClass]
    public class NamesTester
    {
        /*
         * Check that the Names class ToString method works correctly
         */
        [TestMethod]
        public void toStringTest()
        {
            Names expected = new Names("Hunter Uriah Mathew", "Clarke");
            Assert.AreEqual(expected.ToString(), "Hunter Uriah Mathew Clarke");
        }
    }
}
