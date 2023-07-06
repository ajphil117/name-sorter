
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

/* CREATE NAME SORTER
 * 
 *  - given set of names
 *  - order first by last name, then by given names
 *  - a name may have up to 3 given names
 *  
 *  CRITERIA
 *  - ensure can run with "name-sorter ./unsorted-names-list.txt"
 *  - create unit tests
 *  - write minimal, practical documentation
 *  - check against SOLID principles
 */

namespace name_sorter
{
    public class Program
    {
        private static void Main(string[] args)
        {
            // Variables        
            string SAVE_FILE_PATH = String.Format(@"{0}\sorted-names-list.txt", Environment.CurrentDirectory);

            List<Names> unsortedNames = new List<Names>();
            List<string> sortedNames = new List<string>();
            string[] namesArray;

            // Load names file
            try
            {
                unsortedNames = LoadFile(args[0]);
            }
            catch (IndexOutOfRangeException ex) 
            {
                Console.WriteLine("Please provide file path as an argument.");
                return;
            }            

            // Sort Names
            sortedNames = SortNames(unsortedNames);

            // Print sorted names
            foreach (var line in sortedNames)
            {
                Console.WriteLine(line);
            }

            // Save sorted names to file
            namesArray = sortedNames.ToArray();
            File.WriteAllLines(SAVE_FILE_PATH.ToString(), namesArray);
        }

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
            catch (Exception e)
            {
                // File is open, stop program:
                Console.WriteLine(fileError);
            }

            // Return list of Name objects
            return namesList;
        }

        public static List<string> SortNames(List<Names> unsortedNames)
        {
            // Variables
            List<Names> sortedNames = new List<Names>();
            List<string> sortedNamesString = new List<string>();

            // Sort names
            sortedNames = unsortedNames.OrderBy(name => name.lastName)
                                       .ThenBy(person => person.givenNames)
                                       .ToList();

            // Convert to list of strings
            foreach (Names name in sortedNames)
            {
                sortedNamesString.Add(name.ToString());
            }

            // Return list of strings
            return sortedNamesString;
        }
    }
}



