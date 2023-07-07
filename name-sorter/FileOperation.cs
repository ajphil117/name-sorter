using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace name_sorter
{
    /// <summary>
    /// This class handels all file operations.
    /// It contains the method to load and save new/overwrite existing text files.
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
            string fileError = "Failed: File failed to load..";
            List<string> fileContents = new List<string>();
            List<Names> namesList = new List<Names> { };


            //Check file state
            try
            {
                // Load file and assign to list variable
                fileContents = File.ReadAllLines(FILE_PATH).ToList();

                // Create list of Name objects
                foreach (var line in fileContents)
                {
                    int finalSpace = line.LastIndexOf(" ");
                    if (finalSpace != -1)
                    {
                        string givenNames = line[..finalSpace];
                        string lastName = line[(finalSpace + 1)..];

                        namesList.Add(new Names(givenNames, lastName));
                    }
                }
            }
            catch (Exception ex)
            {
                // File is open, stop program:
                Console.WriteLine(fileError);
            }

            // Return list of Name objects
            return namesList;
        }

        /// <summary>
        /// This method saves a file to the current working directory of the sorted names.
        /// If the files already exists, it will overwrite it.
        /// </summary>
        /// 
        /// <param name="filePath"> The path to save the file. </param>
        /// <param name="namesArray"> The sorted names to save to the file. </param>
        public static void SaveFile(string filePath, string[] namesArray)
        {
            File.WriteAllLines(filePath, namesArray);
        }
    }
}
