using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Security.Cryptography;

namespace name_sorter.tests
{
    /// <summary>
    /// This test class tests the SaveFile method from the FileOperation class.
    /// It contains the test to save a new file and to check that file contents are equal.  
    /// </summary>
    [TestClass]
    public class SaveFileTester
    {        
        /// <summary>
        /// Tests the FileOperation class SaveFile method.
        /// </summary>
        [TestMethod]
        public void simpleSaveTest()
        {
            // Variables
            List<string> sortedExpected = new List<string>();

            // Create sorted names array
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
            
            // Save file
            FileOperation.SaveFile(sortedExpected.ToArray());

            // Check match
            filesEqual("samples/sortedNames.txt", "sorted-names-list.txt");
        }

        /// <summary>
        /// Method to check if file's contents are equal.
        /// </summary>
        /// 
        /// <param name="answerFile"> The path of the expected answer file. </param>
        /// <param name="testFile"> The path of the actual test file. </param>
        private void filesEqual(string answerFile, string testFile)
        {
            // Variables
            byte[] hashOne;
            byte[] hashTwo;

            // Get hash values of file contents
            using (var md5 = MD5.Create())
            {
                using (var stream = File.OpenRead(answerFile))
                {
                    hashOne = md5.ComputeHash(stream);
                }
            }
            
            using (var md5 = MD5.Create())
            {
                using (var stream = File.OpenRead(testFile))
                {
                    hashTwo = md5.ComputeHash(stream);
                }
            }

            // Check match
            Assert.IsTrue(hashOne.SequenceEqual(hashTwo));
        }
    }
}