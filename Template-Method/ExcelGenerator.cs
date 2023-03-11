namespace Template_Method
{
    internal class ExcelGenerator : Generator
    {
        protected override void GenerateFile()
        {
            Console.WriteLine("Generate excel file");
        }

        protected override void PrepareData()
        {
            Console.WriteLine("Prepare data for excel");
        }
    }
}
