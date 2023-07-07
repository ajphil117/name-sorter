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
        /// Constructor for the Names object.
        /// </summary>
        /// 
        /// <param name="givenNames"> The given names. </param>
        /// <param name="lastName"> The last name. </param>
        public Names(string givenNames, string lastName)
        {
            this.givenNames = givenNames;
            this.lastName = lastName;
        }

        /// <summary>
        /// This override method converts a Names object into a string.
        /// </summary>
        /// 
        /// <returns> The string represtation of the Names object. </returns>
        public override string ToString() => $"{givenNames} {lastName}";

        /// <summary>
        /// This override method checks that two Names objects are equal.
        /// </summary>
        /// 
        /// <param name="obj"> The Names object to test against. </param>
        /// <returns> True if the Names objects are equal, false otherwise. </returns>
        public override bool Equals(Object obj)
        {
            // Variables
            Names that = (Names)obj;

            // Check that both objects are Names objects
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }            
            
            // Check match
            return givenNames == that.givenNames && lastName == that.lastName;
        }

        /// <summary>
        /// This override method converts a Names object into a string.
        /// </summary>
        /// 
        /// <returns> The hash code for the Names object. </returns>
        public override int GetHashCode() => givenNames.GetHashCode() * 97 + lastName.GetHashCode();
    }
}
