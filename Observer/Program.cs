// Observer (Obserwator) - wzorzec służący do tworzenia mechanizmu subskrypcji w celu powiadamiania
//             wielu obiektów o zdarzeniach dziejących się w obserwowanym obiekcie
//             np. do wykorzystania w sklepie przy powiadamianiu o dostępności danego towaru

using Observer;

var subscriber1 = new Subscriber("subscriber1");
var subscriber2 = new Subscriber("subscriber2");
var subscriber3 = new Subscriber("subscriber3");

var item1 = new Item()
{
    Name = "Item1",
    ItemId = "001"
};

var item2 = new Item()
{
    Name = "Item2",
    ItemId = "002"
};

var item3 = new Item()
{
    Name = "Item3",
    ItemId = "003"
};
var publisher = new Publisher();

publisher.Subscribe(subscriber1, item1);
publisher.Subscribe(subscriber1, item2);
publisher.Subscribe(subscriber2, item1);
publisher.Subscribe(subscriber3, item3);

publisher.Notify(item1);
publisher.Notify(item2);

Console.WriteLine();
publisher.Unsubscribe(subscriber1, item1);

publisher.Notify(item1);

Console.WriteLine();

publisher.Notify(item3);
publisher.Unsubscribe(subscriber3, item3);
publisher.Notify(item3);
