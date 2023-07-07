using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace name_sorter
{
    /// <summary>
    /// This class contains the expection that is thrown when the unsorted names file
    /// is invalid (i.e. incorrect format or issues being read).
    /// </summary>
    public class InvalidNamesFileException : System.Exception
    {
        public InvalidNamesFileException() : base() { }
        public InvalidNamesFileException(string message) : base(message) { }
        public InvalidNamesFileException(string message, System.Exception inner) : base(message, inner) { }
    }
}
