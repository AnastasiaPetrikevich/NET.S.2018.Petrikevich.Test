using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5.Solution
{
    public abstract class DocumentPart
    {
        public string Text { get; set; }

        public abstract string ConvertTo(IConverter converter);

    }
}
