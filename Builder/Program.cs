//Builder (Budowniczy)
//Służy do tworzenia obiektów bardziej rozbudowanych typów (klas). Tutaj na przykładzie faktur.
//IBuilder - dodatkowy interfejs do implementacji różnych rachunków (faktura, paragon, itp.)
//Director - Kierownik, który dzięki interfejsowi IBuilder może tworzyć np. szablony rachunków 
//           tj. faktura pusta, zbiorcza faktura miesięczna itp.
//dodatkowo użyłem
// - typu generycznego określającego format listy towarów/usług na fakturze
// - interfejsu IPrint do roboczego wyświetlania faktur i ich składowych

using Builder;
using System;

InvoiceBuilder<InvoiceItem> builder = new InvoiceBuilder<InvoiceItem>();

Person vendor = new Person()
{
    FirstName = "John",
    LastName = "Doe",
    City = "New York"
};

Person vendee = new Person()
{
    FirstName = "Jan",
    LastName = "Kowalski",
    City = "Warszawa"
};

var items = new List<InvoiceItem>
{
    new InvoiceItem()
    {
        Id = "1.",
        Name = "Some item",
        Price = 10.2F
    },
    new InvoiceItem()
    {
        Id = "2.",
        Name = "Some other very long item",
        Price = 5F
    }
};

Invoice<InvoiceItem> newInvoice =
    builder.setNumber("1.")
    .setDate(DateTime.Now.ToString("dd.MM.yyyy"))
    .setVendor(vendor)
    .setVendee(vendee)
    .setItemLists(items)
    .Build();

newInvoice.Print();

Console.WriteLine();

Director<InvoiceItem> director = new Director<InvoiceItem>();
Invoice<InvoiceItem> blankIvoice = director.CreateBlankInvoice();
blankIvoice.Print();