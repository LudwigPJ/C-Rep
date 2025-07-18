using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestGame.Ships;

namespace TestGame.Rout
{
    public abstract class SpaceRout
    {
       
    
    
        public string name { get;  set; }
        public int distance { get;  set; }


        
        public virtual string ToString(SpaceRout rout, SpaceShip ship)
        {
            return $"{name}, Distance: {distance} light-years";
        }

        
        
            
        




    }
    




}
