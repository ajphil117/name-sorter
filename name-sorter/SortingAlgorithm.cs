using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace name_sorter
{
    /// <summary>
    /// The class to sort names lists.
    /// </summary>
    public class SortingAlgorithm
    {
        /// <summary>
        /// This method sorts the names list by last names first, then any given names and
        /// then converts the list into a string list to be returned.
        /// </summary>
        /// 
        /// <param name="unsortedNames"> The names list to sort. </param>
        /// <returns> Returns a list of strings containing the sorted names. </returns>
        public static List<string> SortNames(List<Names> unsortedNames)
        {
            // Variables
            List<Names> sortedNames = new List<Names>();
            List<string> sortedNamesString = new List<string>();

            // Sort names
            sortedNames = unsortedNames.OrderBy(name => name.LastName)
                                       .ThenBy(person => person.GivenNames)
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
