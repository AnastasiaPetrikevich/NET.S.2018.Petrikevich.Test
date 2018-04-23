using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Solution
{
    public class RandomBytesFileGenerator : RandomFileGenerator
    {
        public RandomBytesFileGenerator(string WorkingDirectory, string FileExtension):base(WorkingDirectory,FileExtension)
        { }

        internal override byte[] GenerateFileContent(int contentLength)
        {
            var random = new Random();

            var fileContent = new byte[contentLength];

            random.NextBytes(fileContent);

            return fileContent;
        }
    }
}
