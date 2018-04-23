using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.Solution;

namespace Task2.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            RandomFileGenerator charFile = new RandomCharsFileGenerator("Files with random chars", ".txt");
            charFile.GenerateFiles(1, 100);
            RandomFileGenerator bytesFile = new RandomBytesFileGenerator("Files with random bytes", ".bytes");
            bytesFile.GenerateFiles(1, 100);
        }
    }
}
