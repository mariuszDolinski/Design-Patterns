using System.Drawing;
using System;

namespace Builder
{
    internal class Invoice<T> : IPrint where T : class, IPrint
    {
        public string Number { get; set; }
        public string Date { get; set; }
        public Person Vendor { get; set; }
        public Person Vendee { get; set; }
        public IEnumerable<T> ItemsList { get; set; }

        public void Print()
        {
            Console.WriteLine($"Invoce no. {Number}");
            Console.WriteLine($"Date: {Date}");
            Console.Write("Vendor: ");
            Vendor.Print();
            Console.Write("Vendee: ");
            Vendee.Print();
            if (ItemsList.Count() == 0 || ItemsList == null)
                Console.WriteLine("---Empty item list---");
            else
                foreach (var item in ItemsList)
                {
                    item.Print();
                }
        }
    }
}