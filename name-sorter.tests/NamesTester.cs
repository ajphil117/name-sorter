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
            var a = new Names("Hunter Uriah Mathew", "Clarke");
            Assert.AreEqual(a.ToString(), "Hunter Uriah Mathew Clarke");
        }
    }
}
