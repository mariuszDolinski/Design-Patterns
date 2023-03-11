namespace Template_Method
{
    internal abstract class Generator
    {
        public void GenerateReport()//metoda szablonowa
        {
            GetData();
            PrepareData();
            GenerateFile();
            SendFile();
        }
        protected virtual void GetData()
        {
            Console.WriteLine("Base get data");
        }
        protected abstract void PrepareData();
        protected abstract void GenerateFile();
        protected void SendFile()
        {
            Console.WriteLine("Sending generated report.");
        }
    }
}
