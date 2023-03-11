using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Method
{
    internal class PdfGenerator : Generator
    {
        protected override void GenerateFile()
        {
            Console.WriteLine("Generate pdf file");
        }
        protected override void PrepareData()
        {
            Console.WriteLine("Prepare data for pdf");
        }
        protected override void GetData()
        {
            Console.WriteLine("Pdf get data override"); 
        }

    }
}
