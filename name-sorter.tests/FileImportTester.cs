using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using name_sorter;

namespace name_sorter.tests
{
    [TestClass]
    public class FileImportTester
    {
        [TestMethod]
        [DeploymentItem(@"samples\simpleNames.txt")]
        public void importTest()
        {
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

            List<Names> namesActual = new List<Names>();

            for (int i = 0; i < givenNames.Count; i++)
            {
                namesActual.Add(new Names(givenNames[i], lastNames[i]));
            }

            List<Names> namesExpected = new List<Names>();
            namesExpected = Program.LoadFile("simpleNames.txt");
            

            // Print sorted names
            foreach (var line in namesExpected)
            {
                Console.WriteLine(line);
            }

            Assert.AreEqual(namesExpected, namesActual);
        }

        [TestMethod]
        public void invalidPathTest()
        {

        }

        [TestMethod]
        public void emptyFileTest()
        {

        }

        [TestMethod]
        public void invalidNamesTest()
        {

        }        
    }
}