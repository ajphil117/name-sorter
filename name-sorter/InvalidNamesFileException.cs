using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace name_sorter
{
    /// <summary>
    /// This class contains the exception that is thrown when the unsorted names file
    /// is invalid (i.e. incorrect format or issues being read).
    /// </summary>
    public class InvalidNamesFileException : System.Exception
    {
        /// <summary>
        /// The base class for the InvalidNamesFileException.
        /// </summary>
        public InvalidNamesFileException() : base() { }

        /// <summary>
        /// The class for InvalidNamesFileException with a message.
        /// </summary>
        /// <param name="message"></param>
        public InvalidNamesFileException(string message) : base(message) { }

        /// <summary>
        /// The class for InvalidNamesFileException with a message and system exception.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="inner"></param>
        public InvalidNamesFileException(string message, System.Exception inner) : base(message, inner) { }
    }
}
