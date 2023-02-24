namespace Singleton
{
    internal class Configuration
    {
        private static Configuration _instance = null;
        private static object _instanceLock = new object();
        private Configuration() 
        { 
        }
        public string StringProperty { get; set; }
        public int IntProperty { get; set; }
        public static Configuration GetInstance()
        {
            //używamy locka na wypadek gdyby dwa różne wątki działające niezależnie od siebie
            //jednocześnie chciały stworzyć obiekt Configuration, wtedy mogłoby dojść do utworzenia
            //dwóch obiektów i nie byłby to Singleton. Lock blokuje dostęp do kodu innym wątkom,
            //gdy jeden go wywołuje. Daj nam to gwarancje, że tylko jeden wątek w tym samym czasie
            //może wykonać ciało metody GetInstance
            lock (_instanceLock)
            {
                if (_instance == null)
                {
                    _instance = new Configuration();
                }
            }
            return _instance;
        }
    }
}
