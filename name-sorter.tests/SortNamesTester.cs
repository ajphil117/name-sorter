using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace name_sorter.tests
{
    /// <summary>
    /// This test class tests the methods within the SortingAlgorithm class.
    /// </summary>
    [TestClass]
    public class SortNamesTester
    {
        /// <summary>
        /// Tests the SortingAlgorithm method SortNames under simple circumstances.
        /// </summary>
        [TestMethod]
        public void simpleSortTest()
        {
            // Variables
            List<string> sortedExpected = new List<string>();

            // Create sorted and unsorted names lists to compare           
            // Sorted names list
            List<string> sortedGivenNames = new List<string> {
                "Marin",
                "Adonis Julius",
                "Beau Tristan",
                "Hunter Uriah Mathew",
                "Leo",
                "Vaughn",
                "London",
                "Mikayla",
                "Janet",
                "Frankie Conner",
                "Shelby Nathan"
            };
            List<string> sortedLastNames = new List<string> {
                "Alvarez",
                "Archer",
                "Bentley",
                "Clarke",
                "Gardner",
                "Lewis",
                "Lindsey",
                "Lopez",
                "Parsons",
                "Ritter",
                "Yoder"
            };

            List<Names> sortedNames = NamesListGenerator.namesListGenerator(sortedGivenNames, sortedLastNames);
            
            // Convert sortedNames to list of strings
            foreach (Names name in sortedNames)
            {
                sortedExpected.Add(name.ToString());
            }

            // Unsorted names list
            List<string> givenNames = new List<string> {
                "Janet",
                "Vaughn",
                "Adonis Julius",
                "Shelby Nathan",
                "Marin",
                "London",
                "Beau Tristan",
                "Leo",
                "Hunter Uriah Mathew",
                "Mikayla",
                "Frankie Conner"
            };
            List<string> lastNames = new List<string> {
                "Parsons",
                "Lewis",
                "Archer",
                "Yoder",
                "Alvarez",
                "Lindsey",
                "Bentley",
                "Gardner",
                "Clarke",
                "Lopez",
                "Ritter"
            };
            
            List<Names> unsortedNames = NamesListGenerator.namesListGenerator(givenNames, lastNames);            

            // Sort unsorted names
            List<string> sortedActual = SortingAlgorithm.SortNames(unsortedNames);

            // Compare the output to the pre-sorted names
            CollectionAssert.AreEqual(sortedExpected, sortedActual);
        }

        /// <summary>
        /// Tests the SortingAlgorithm method SortNames with duplicate last names.
        /// </summary>
        [TestMethod]
        public void sameLastNameTest()
        {
            // Variables
            List<string> sortedExpected = new List<string>();

            // Create sorted and unsorted names lists to compare           
            // Sorted names list
            List<string> sortedGivenNames = new List<string> {
                "Abbey",
                "Robert Stone",
                "Martha",
                "Mickey",
                "Leo",
                "Velma Louise"
            };
            List<string> sortedLastNames = new List<string> {
                "Banks",
                "Banks",
                "Jones",
                "Jones",
                "Smith",
                "Smith"
            };

            List<Names> sortedNames = NamesListGenerator.namesListGenerator(sortedGivenNames, sortedLastNames);

            // Convert sortedNames to list of strings
            foreach (Names name in sortedNames)
            {
                sortedExpected.Add(name.ToString());
            }

            // Unsorted names list
            List<string> givenNames = new List<string> {
                "Martha",
                "Velma Louise",
                "Abbey",
                "Mickey",
                "Robert Stone",               
                "Leo"                
            };
            List<string> lastNames = new List<string> {
                "Jones",
                "Smith",
                "Banks",
                "Jones",
                "Banks",           
                "Smith"                
            };

            List<Names> unsortedNames = NamesListGenerator.namesListGenerator(givenNames, lastNames);

            // Sort unsorted names
            List<string> sortedActual = SortingAlgorithm.SortNames(unsortedNames);

            // Compare the output to the pre-sorted names
            CollectionAssert.AreEqual(sortedExpected, sortedActual);
        }

        /// <summary>
        /// Tests the SortingAlgorithm method SortNames with duplicate given names.
        /// </summary>
        [TestMethod]
        public void sameGivenNamesTest()
        {
            // Variables
            List<string> sortedExpected = new List<string>();

            // Create sorted and unsorted names lists to compare           
            // Sorted names list
            List<string> sortedGivenNames = new List<string> {
                "Abbey Jnr",
                "Abbey Snr",
                "Julien",
                "Leo",
                "Leo",
                "Leo"
            };
            List<string> sortedLastNames = new List<string> {
                "Banks",
                "Banks",
                "Jones",
                "Jones",
                "Smith",
                "Smith"
            };

            List<Names> sortedNames = NamesListGenerator.namesListGenerator(sortedGivenNames, sortedLastNames);

            // Convert sortedNames to list of strings
            foreach (Names name in sortedNames)
            {
                sortedExpected.Add(name.ToString());
            }

            // Unsorted names list
            List<string> givenNames = new List<string> {
                "Julien",
                "Leo",
                "Abbey Snr",
                "Leo",
                "Abbey Jnr",
                "Leo"
            };
            List<string> lastNames = new List<string> {
                "Jones",
                "Smith",
                "Banks",
                "Jones",
                "Banks",
                "Smith"
            };

            List<Names> unsortedNames = NamesListGenerator.namesListGenerator(givenNames, lastNames);

            // Sort unsorted names
            List<string> sortedActual = SortingAlgorithm.SortNames(unsortedNames);

            // Compare the output to the pre-sorted names
            CollectionAssert.AreEqual(sortedExpected, sortedActual);
        }
    }
}
