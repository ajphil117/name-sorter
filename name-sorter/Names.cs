using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace name_sorter
{
    /// <summary>
    /// This class provides the methods for constucting a Names object and
    /// converting the object into a string.
    /// </summary>
    public class Names
    {
        public string givenNames { get; }
        public string lastName { get; }
        
        /// <summary>
        /// Constructor for a Names object.
        /// </summary>
        /// 
        /// <param name="givenNames"> The given names of the person. </param>
        /// <param name="lastName"> The last name of the person. </param>
        public Names(string givenNames, string lastName)
        {
            this.givenNames = givenNames;
            this.lastName = lastName;
        }

        /// <summary>
        /// This method converts a Names object into a string.
        /// </summary>
        /// 
        /// <returns> The string represtation of the Names object. </returns>
        public override string ToString() => $"{givenNames} {lastName}";
    }
}
