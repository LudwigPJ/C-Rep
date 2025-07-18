using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestGame.Ships;

namespace TestGame.Rout
{
    public class AsteroidFieldRoute : SpaceRout
    {
        public AsteroidFieldRoute(string name, int distance)
        {
            this.name = name;
            this.distance = distance;
        }
        public override string ToString(SpaceRout route, SpaceShip ship)
        {
            return $"{ship.name}\t пройдет {route.name},\t дистанцию: {route.distance}\t light-years за \t {route.distance * ship.armor}";
        }

       


    }
}
