using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace name_sorter.tests
{
    /// <summary>
    /// This class holds the method to generate a Names list.
    /// </summary>
    public class NamesListGenerator
    {
        /// <summary>
        /// Method to generate list of names.
        /// </summary>
        /// 
        /// <param name="givenNames"> The given names. </param>
        /// <param name="lastNames"> The last names. </param>
        /// <returns> Returns a list of Names objects. </returns>
        public static List<Names> namesListGenerator(List<string> givenNames, List<string> lastNames)
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
