namespace Strategy
{
    internal class CarStrategy : IRouteStrategy
    {
        void IRouteStrategy.createRoute(Coordinate start, Coordinate end)
        {
            Console.WriteLine($"Create route for bike from point ({start.Lat}, {start.Long})" +
                $" to point ({end.Lat}, {end.Long})");
        }
    }
}
