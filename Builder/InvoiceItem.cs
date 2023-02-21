namespace Builder
{
    internal class InvoiceItem : IPrint
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }

        public void Print()
        {
            Console.Write($"{Id,-4}");
            Console.Write($"{(Name.Length > 15 ? Name.Substring(0, 15)+"...": Name),-20}");
            Console.WriteLine($"{Price} USD");
        }
    }
}