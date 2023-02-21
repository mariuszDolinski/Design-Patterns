namespace Builder
{
    internal class Director<T> where T : class, IPrint
    {
        private IInvoiceBuilder<T> _invoice = new InvoiceBuilder<T>();

        public Invoice<T> CreateBlankInvoice()
        {
            return _invoice.setNumber("--Blank Invoice--")
                .setDate("--No date--")
                .setVendee(new Person())
                .setVendor(new Person())
                .setItemLists(new List<T>())
                .Build();
        }
    }
}