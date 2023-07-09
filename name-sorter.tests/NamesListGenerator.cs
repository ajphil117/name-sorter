using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace name_sorter.tests
{
    /// <summary>
    /// This class holds the method to generate a list of Names objects.
    /// </summary>
    public class NamesListGenerator
    {
        /// <summary>
        /// Method to generate list of Names objects.
        /// </summary>
        /// 
        /// <param name="givenNames"> The given names. </param>
        /// <param name="lastNames"> The last names. </param>
        /// <returns> Returns a list of Name objects. </returns>
        public static List<Names> GenerateNamesList(List<string> givenNames, List<string> lastNames)
        {
            // Variables
            var names = new List<Names> { };

            // Generate list
            for (int i = 0; i < givenNames.Count; ++i)
            {
                names.Add(new Names(givenNames[i], lastNames[i]));
            }

            // Return list
            return names;
        }
    }
}
