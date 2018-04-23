using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5.Solution
{
    public interface IConverter
    {
        string BoldTextConvert(string text);
        string PlainTextConvert(string text);
        string HyperlinkConvert(string text, string url);
    }
}
