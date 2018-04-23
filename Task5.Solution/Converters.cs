using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5.Solution
{
    public class HtmlConverter : IConverter
    {
        public string BoldTextConvert(string text)
        {
            return "<b>" + text + "</b>";
        }

        public string HyperlinkConvert(string text, string url)
        {
            return "<a href=\"" + url + "\">" + text + "</a>";
        }

        public string PlainTextConvert(string text)
        {
            return text;
        }
    }

    public class PlainTextConverter : IConverter
    {
        public string BoldTextConvert(string text)
        {
            return "**" + text + "**";
        }

        public string HyperlinkConvert(string text, string url)
        {
            return text + " [" + url + "]";
        }

        public string PlainTextConvert(string text)
        {
            return text;
        }
    }

    public class LaTeXConverter : IConverter
    {
        public string BoldTextConvert(string text)
        {
            return "\\textbf{" + text + "}";
        }

        public string HyperlinkConvert(string text, string url)
        {
            return "\\href{" + url + "}{" + text + "}";
        }

        public string PlainTextConvert(string text)
        {
            return text;
        }
    }

}

