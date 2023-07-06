using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace name_sorter
{
    public class Names
    {
        public string givenNames { get; }
        public string lastName { get; }
        public Names(string givenNames, string lastName)
        {
            this.givenNames = givenNames;
            this.lastName = lastName;
        }

        public override string ToString() => $"{givenNames} {lastName}";

    }
}
