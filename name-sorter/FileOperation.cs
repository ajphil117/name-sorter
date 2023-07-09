using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace name_sorter
{
    /// <summary>
    /// This class handles all file operations.
    /// It contains the methods to load and save new/overwrite existing text files.
    /// </summary>
    public class FileOperation
    {
        /// <summary>
        /// This method loads the names list text file from the file path given.
        /// </summary>
        /// 
        /// <param name="FILE_PATH"> The file path to load file from. </param>
        /// <returns> Returns list of names to be sorted. </returns>
        public static List<Names> LoadFile(string FILE_PATH)
        {
            // Variables
            string readException = "The file could not be read.";
            string invalidException = "The names file provided is invalid.";
            string[] readNames;
            List<string> fileContents;
            int finalSpace;
            List<Names> namesList = new List<Names>();


            // Try to read file
            try
            {
                // Load file and assign to list variable
                readNames = File.ReadAllLines(FILE_PATH);
                fileContents = readNames.ToList();               
            }
            catch
            {
                // File cannot be read, throw error and stop program
                throw new InvalidNamesFileException(readException);
            }

            // Create list of Names objects
            foreach (var name in fileContents)
            {
                finalSpace = name.LastIndexOf(" ");
                if (finalSpace < 1)
                {
                    // Missing given names, throw error and stop program
                    throw new InvalidNamesFileException(invalidException);
                }

                string givenNames = name.Substring(0, finalSpace);
                string lastName = name.Substring(finalSpace + 1);

                namesList.Add(new Names(givenNames, lastName));
            }

            // Return list of Names objects
            return namesList;
        }

        /// <summary>
        /// This method saves a file of sorted names called "sorted-names-list.txt"
        /// to the current working directory.
        /// If the files already exists, it will overwrite it.
        /// </summary>
        /// 
        /// <param name="namesArray"> The sorted names to save to the file in string array format. </param>
        public static void SaveFile(string[] namesArray)
        {
            // Variables
            string filePath = String.Format(@"{0}\sorted-names-list.txt", Environment.CurrentDirectory);

            // Save file
            File.WriteAllLines(filePath.ToString(), namesArray);
        }
    }
}
