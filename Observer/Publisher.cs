using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    internal class Publisher 
    {
        private Dictionary<string, List<ISubscriber>> _subscribers = 
            new Dictionary<string, List<ISubscriber>>();

        public void Subscribe(ISubscriber subscriber, Item item)
        {
            if (!_subscribers.ContainsKey(item.ItemId))
            {
                _subscribers.Add(item.ItemId, new List<ISubscriber>());
            }
            _subscribers[item.ItemId].Add(subscriber);
        }
        public void Unsubscribe(ISubscriber subscriber, Item item)
        {
            if (_subscribers.ContainsKey(item.ItemId))
            {
                _subscribers[item.ItemId].Remove(subscriber);
            }
            else
            {
                Console.WriteLine($"Item {item.Name} cannot be subscribed");
            }
        }

        public void Notify(Item item)
        {
            if (_subscribers.ContainsKey(item.ItemId))
            {
                foreach (ISubscriber subscriber in _subscribers[item.ItemId])
                {
                    subscriber.Update(item);
                }
            }
        }
    }
}
