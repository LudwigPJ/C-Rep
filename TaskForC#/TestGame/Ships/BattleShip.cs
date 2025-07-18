using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGame.Ships
{
    public class BattleShip : SpaceShip
    {
        public BattleShip(int speed, string name, int armor, int agility, int power)
        {
            this.speed = speed*10;
            this.name = name;
            this.armor = armor*5;
            this.agility = agility*7;
            this.power = power*15;
        }
        public override string ToString()
        {
            return $"BattleShip:\t {name},\t Speed: {speed},\t Armor: {armor},\t Agility: {agility},\t Power: {power}";
        }
    }
}
