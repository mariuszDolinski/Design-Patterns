namespace Observer
{
    internal class Subscriber : ISubscriber
    {
        public string Name { get; set; }
        public Subscriber(string name)
        {
            Name = name;
        }
        public void Update(Item item)
        {
            Console.WriteLine($"Subscriber {Name} notifed that {item.Name} is now avalaible");
        }
    }
}
