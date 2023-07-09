using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace name_sorter
{
    /// <summary> 
    /// This class holds the Main to run the program.
    /// </summary>
    public class Program
    {
        private static void Main(string[] args)
        {
            // Variables        
            List<Names> unsortedNames;
            List<string> sortedNames;

            // Load names file
            try
            {
                unsortedNames = FileOperation.LoadFile(args[0]);
            }
            catch 
            {
                Console.WriteLine("Please provide file path as an argument.");
                return;
            }            

            // Sort names
            sortedNames = SortingAlgorithm.SortNames(unsortedNames);

            // Print sorted names
            foreach (var line in sortedNames)
            {
                Console.WriteLine(line);
            }

            // Save sorted names to file
            FileOperation.SaveFile(sortedNames.ToArray());
        }      
    }
}