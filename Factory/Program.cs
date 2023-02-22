//Factory (Fabryka) - służy do tworzenia klas pewnego abstrakcyjnego typu (w tym przykładzie Shape)

using Factory;

ShapeFactory shapeFactory= new ShapeFactory();

var circle = shapeFactory.CreateShape(ShapeType.Circle);
circle.Render();

var triangle = shapeFactory.CreateShape(ShapeType.Triangle);
triangle.Render();