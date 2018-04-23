using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5.Solution
{
    public class PlainText : DocumentPart
    {
        public override string ConvertTo(IConverter converter)
        {
            return converter.PlainTextConvert(Text);
        }
    }
}
