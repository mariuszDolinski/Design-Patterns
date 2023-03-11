using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Method
{
    internal class CsvGenerator : Generator
    {
        protected override void GenerateFile()
        {
            Console.WriteLine("Generate csv file");
        }

        protected override void PrepareData()
        {
            Console.WriteLine("Prepare data for csv");
        }
    }
}