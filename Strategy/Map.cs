namespace Strategy
{
    internal class Map
    {
        private IRouteStrategy _routeStrategy;

        public Map(IRouteStrategy routeStrategy)
        {
            _routeStrategy = routeStrategy;
        }

        public void createRoute(Coordinate start, Coordinate end)
        {
            _routeStrategy.createRoute(start, end);
        }
    }
}
