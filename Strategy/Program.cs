//Strategy (strategia) - służy do definiowania rodziny algorytmów i kapsułkue je w postaci klas
//                       onaczej pozwala na używanie różnych wariantów algorytmu w ramach jednego obiektu
//                       w trakcie działania programu
//            Przykład stosowania: aplikacja mapy do wyznaczania tras z punktu A do B
//                    można mieć różne algorytmy dla trasy pokonywane samochodem, rowerem, pieszo, itp.

using Strategy;

var strategy = new BikeStrategy();

Map map = new Map(strategy);

Coordinate start = new Coordinate()
{
    Long = 123.1212,
    Lat = 53.4323
};
Coordinate end = new Coordinate()
{
    Long = 125.3234,
    Lat = 52.9354
};

map.createRoute(start, end);
