using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGame.Ships
{
    public class ScouShip : SpaceShip
    {
       public ScouShip(int speed, string name, int armor, int agility, int power)
        {
            this.speed = speed*25;
            this.name = name;
            this.armor = armor-50;
            this.agility = agility*30;
            this.power = power*5;
        }
        public override string ToString()
        {
            return $"ScouShip:\t {name},\t Speed: {speed},\t Armor: {armor},\t Agility: {agility},\t Power: {power}";
        }

        
    }
}
