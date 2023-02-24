using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class BikeStrategy : IRouteStrategy
    {
        void IRouteStrategy.createRoute(Coordinate start, Coordinate end)
        {
            Console.WriteLine($"Create route for bike from point ({start.Lat}, {start.Long})" +
                $" to point ({end.Lat}, {end.Long})");
        }
    }
}
