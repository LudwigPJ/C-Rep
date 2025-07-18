using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGame.Ships
{
    public abstract class SpaceShip
    {
        public int speed { get; protected set; }
        public string name;
        public int armor { get; protected set; }
        public int agility { get; protected set; }
        public int power { get; protected set; }


    }
}
