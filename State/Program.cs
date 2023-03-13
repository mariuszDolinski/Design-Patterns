// State (stan) - wzorzec pozwalający na zmianę zachowania obiektu poprzez zmianę jego wewnętrznego stanu
//                Przykład: aplikacja do obsługi bankomatu. Może mieć różne stany w zależności od sytuacji
//                 np. karta nie włożona, karta włozona nie podany pin, podany pin, brak gotówki
//                 W zalezności od stanu aplikacja powinna zachowywać się inaczej

using State;

var context = new Context();
context.begin();


