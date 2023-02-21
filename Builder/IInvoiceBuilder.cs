namespace Builder
{
    internal interface IInvoiceBuilder<T> where T : class, IPrint
    {
        public Invoice<T> Build();
        public InvoiceBuilder<T> setNumber(string number);
        public InvoiceBuilder<T> setDate(string date);
        public InvoiceBuilder<T> setVendor(Person person);
        public InvoiceBuilder<T> setVendee(Person person);
        public InvoiceBuilder<T> setItemLists(IEnumerable<T> list);
    }
}
