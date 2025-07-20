using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGame.Ships
{
    public class CargoShip : SpaceShip
    {
        public CargoShip(int speed, string name, int armor, int agility, int power)
        {
            this.speed = speed*5;
            this.name = name;
            this.armor = armor*12;
            this.agility = agility*16;
            this.power = power*13;
        }
        public override string ToString()
        {
            return $"CargoShip:\t {name},\t Speed: {speed},\t Armor: {armor},\t Agility: {agility},\t Power: {power}";
        }
    }
}
