using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Task5.Solution
{
    public class Hyperlink : DocumentPart
    {
        public string Url { get; set; }

        public override string ConvertTo(IConverter converter)
        {
            return converter.HyperlinkConvert(Text, Url);
        }
    }
}
}
