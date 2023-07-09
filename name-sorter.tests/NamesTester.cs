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
        public void ToStringTest()
        {
            // Create Name object
            Names expected = new Names("Hunter Uriah Mathew", "Clarke");

            // Check match
            Assert.AreEqual(expected.ToString(), "Hunter Uriah Mathew Clarke");
        }

        /// <summary>
        /// Tests the Names class Equals method when the objects are equal.
        /// </summary>
        [TestMethod]
        public void EqualsTest()
        {
            // Create Name objects
            Names namesOne = new Names("Hunter Uriah Mathew", "Clarke");
            Names namesTwo = new Names("Hunter Uriah Mathew", "Clarke");

            // Check match
            namesOne.Equals(namesTwo);
        }

        /// <summary>
        /// Tests the Names class Equals method when the objects are not equal.
        /// </summary>
        [TestMethod]
        public void NotEqualTest()
        {
            // Create Name objects
            Names namesOne = new Names("Hunter Uriah Mathew", "Clarke");
            Names namesTwo = new Names("London", "Lindsey");

            // Check match
            Assert.IsFalse(namesOne.Equals(namesTwo));
        }
    }
}
