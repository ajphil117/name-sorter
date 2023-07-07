using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace name_sorter.tests
{
    /// <summary>
    /// This test class tests the LoadFile method from the FileOperation class.
    /// It contains tests for a normal import, empty file, invalid file contents,
    /// and invalid path.
    /// </summary>
    [TestClass]
    public class LoadFileTester
    {
        /// <summary>
        /// This test tests the LoadFile method under normal circumstances.
        /// </summary>
        [TestMethod]
        public void importTest()
        {
            // Variables
            string filePath = "samples/simpleNames.txt";
            List<Names> namesExpected = new List<Names>();
            List<Names> namesActual = new List<Names>();

            // Create simple names list
            List<string> givenNames = new List<String> {
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
            List<string> lastNames = new List<String> {
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

            namesExpected = NamesListGenerator.namesListGenerator(givenNames, lastNames);

            // Load sample file to list            
            namesActual = FileOperation.LoadFile(filePath);

            // Check match
            namesExpected.Equals(namesActual);
        }        

        /// <summary>
        /// This test tests the LoadFile method when the file is empty.
        /// </summary>
        [TestMethod]
        public void emptyFileTest()
        {
            // Variables
            string filePath = "samples/empty.txt";
            List<Names> namesExpected = new List<Names> { };

            // Load file
            List<Names> namesActual = FileOperation.LoadFile(filePath);

            // Check match
            namesExpected.Equals(namesActual);
        }

        /// <summary>
        /// This test tests the LoadFile method throws an expection when the file is invalid.
        /// </summary>
        [TestMethod]
        public void invalidNamesTest()
        {
            // Variables
            string filePath = "samples/noGiven.txt";

            // Check error thrown            
            Assert.ThrowsException<InvalidNamesFileException>(() => FileOperation.LoadFile(filePath));
        }

        /// <summary>
        /// This test tests the LoadFile method throws an expection when the file path is invalid.
        /// </summary>
        [TestMethod]
        public void invalidPathTest()
        {
            // Variables
            string filePath = "fileNotExist.txt";

            // Check error thrown            
            Assert.ThrowsException<InvalidNamesFileException>(() => FileOperation.LoadFile(filePath));
        }
    }
}