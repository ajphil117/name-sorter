using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace name_sorter.tests
{
    /// <summary>
    /// This test class tests the methods within the Names class.
    /// Contains tests for the ToString method, and Equals method when the objects
    /// are equal and not.
    /// </summary>
    [TestClass]
    public class NamesTester
    {
        /// <summary>
        /// Tests the Names class ToString method.
        /// </summary>
        [TestMethod]
        public void toStringTest()
        {
            // Create Names object
            Names expected = new Names("Hunter Uriah Mathew", "Clarke");

            // Check match
            Assert.AreEqual(expected.ToString(), "Hunter Uriah Mathew Clarke");
        }

        /// <summary>
        /// Tests the Names class Equals method when the objects are equal.
        /// </summary>
        [TestMethod]
        public void equalsTest()
        {
            // Create Names objects
            Names namesOne = new Names("Hunter Uriah Mathew", "Clarke");
            Names namesTwo = new Names("Hunter Uriah Mathew", "Clarke");
            Names namesThree = new Names("London", "Lindsey");

            // Check match
            namesOne.Equals(namesTwo);
        }

        /// <summary>
        /// Tests the Names class Equals method when the objects are not equal.
        /// </summary>
        [TestMethod]
        public void notEqualTest()
        {
            // Create Names objects
            Names namesOne = new Names("Hunter Uriah Mathew", "Clarke");
            Names namesTwo = new Names("London", "Lindsey");

            // Check match
            Assert.IsFalse(namesOne.Equals(namesTwo));
        }
    }
}
