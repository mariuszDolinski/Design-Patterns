using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class WalkStrategy : IRouteStrategy
    {
        void IRouteStrategy.createRoute(Coordinate start, Coordinate end)
        {
            Console.WriteLine($"Create route for walk from point ({start.Lat}, {start.Long})" +
                $" to point ({end.Lat}, {end.Long})");
        }
    }
}
