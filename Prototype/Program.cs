// Prototype (prototyp) - umożliwia tworzenie kopii istniejących obiektów
//      bez tworzenia zależności między kodem a klasami
//      przydaje się np. do kopiowania (klonowania) stworzonych przez użytkownika kształtów
//          klonowanie płytkie (shallow clone) - nie kopiuje referencji, zostanie ten sam obiekt typu referecyjnego
//          klonowanie głebokie (deep clone) - tworzone są nowe instancje typów referencyjnych

using Prototype;
using Prototype.Figures;

Circle circle = new Circle()
{
    Radius = 10,
    X = 1,
    Y = 2,
    Border = new Border()
    {
        Color = "Red",
        Size = "20px"
    }
};

Triangle triangle = new Triangle()
{
    X = 5,
    Y = 6,
    Border = new Border()
    {
        Color = "Green",
        Size = "10px"
    }
};

Circle cloneCircle = (Circle)circle.Clone();

Console.WriteLine($"Is circles references equals: {ReferenceEquals(circle,cloneCircle)}");
Console.WriteLine($"Is circles borders references equals: {ReferenceEquals(circle.Border,cloneCircle.Border)}");

Console.WriteLine();

Triangle cloneTriangle = (Triangle)triangle.Clone();

Console.WriteLine($"Is triangles references equals: {ReferenceEquals(triangle, cloneTriangle)}");
Console.WriteLine($"Is triangles borders references equals: {ReferenceEquals(triangle.Border, cloneTriangle.Border)}");

Console.WriteLine();
