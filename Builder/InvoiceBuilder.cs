namespace Builder
{
    internal class InvoiceBuilder<T> : IInvoiceBuilder<T> where T : class, IPrint
    {
        private Invoice<T> _invoice = new Invoice<T>();

        public Invoice<T> Build()
        {
            return _invoice;
        }

        public InvoiceBuilder<T> setNumber(string number)
        {
            _invoice.Number = number;
            return this;
        }

        public InvoiceBuilder<T> setDate(string date)
        {
            _invoice.Date = date;
            return this;
        }

        public InvoiceBuilder<T> setVendor(Person person)
        {
            _invoice.Vendor = person;
            return this;
        }

        public InvoiceBuilder<T> setVendee(Person person)
        {
            _invoice.Vendee = person;
            return this;
        }
        public InvoiceBuilder<T> setItemLists(IEnumerable<T> list)
        {
            _invoice.ItemsList = list;
            return this;
        }
    }
}