using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSorterApp
{
    public class NameSorterException : Exception
    {
        public NameSorterException()
        {
        }

        public NameSorterException(string message)
            : base(message)
        {
        }

        public NameSorterException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
