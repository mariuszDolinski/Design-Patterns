// Singleton - wzorzec projektowy służący do tworzenia klasy, która może mieć tylko jedną instancję
//             może posłużyć np. do tworzenia klas konfiguracyjnych, tóe przez cały czas trwania programu
//             powinny mieć niezmienny stan. Łamie jednal zasady SOLID jednej odpowiedzialności i open-close

using Singleton;

var conf1 = Configuration.GetInstance();
var conf2 = Configuration.GetInstance();

if(ReferenceEquals(conf1, conf2))
{
    Console.WriteLine("Configuration is singleton");
}