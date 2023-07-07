using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using name_sorter;
using Microsoft.VisualBasic;
using System.Diagnostics.Metrics;
using System.Collections.Generic;


namespace name_sorter.tests
{
    [TestClass]
    public class SortNamesTester
    {
        /*
         * Check that the SortNames method works correctly under simple circumstances
         */
        [TestMethod]
        public void simpleSortTest()
        {
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

            List<Names> sortedNames = namesListGenerator(sortedGivenNames, sortedLastNames);
            List<string> sortedExpected = new List<string>();

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
            
            List<Names> unsortedNames = namesListGenerator(givenNames, lastNames);            

            // Sort unsorted names
            List<string> sortedActual = SortingAlgorithm.SortNames(unsortedNames);

            // Compare the output to the pre-sorted names
            CollectionAssert.AreEqual(sortedExpected, sortedActual);
        }

        /*
         * Check that the SortNames method works correctly with duplicate last names
         */
        [TestMethod]
        public void sameLastNameTest()
        {
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

            List<Names> sortedNames = namesListGenerator(sortedGivenNames, sortedLastNames);
            List<string> sortedExpected = new List<string>();

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

            List<Names> unsortedNames = namesListGenerator(givenNames, lastNames);

            // Sort unsorted names
            List<string> sortedActual = SortingAlgorithm.SortNames(unsortedNames);

            // Compare the output to the pre-sorted names
            CollectionAssert.AreEqual(sortedExpected, sortedActual);
        }

        /*
         * Check that the SortNames method works correctly with duplicate given names
         */
        [TestMethod]
        public void sameGivenNamesTest()
        {
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

            List<Names> sortedNames = namesListGenerator(sortedGivenNames, sortedLastNames);
            List<string> sortedExpected = new List<string>();

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

            List<Names> unsortedNames = namesListGenerator(givenNames, lastNames);

            // Sort unsorted names
            List<string> sortedActual = SortingAlgorithm.SortNames(unsortedNames);

            // Compare the output to the pre-sorted names
            CollectionAssert.AreEqual(sortedExpected, sortedActual);
        }

       private List<Names> namesListGenerator(List<string> givenNames, List<string> lastNames)
        {
            var names = new List<Names> { };
            for (int i = 0; i < givenNames.Count; ++i)
            {
                names.Add(new Names(givenNames[i], lastNames[i]));
            }
            return names;
        }
    }
}
