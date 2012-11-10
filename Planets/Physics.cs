using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Planets
{
    class Physics
    {
        public static float getNetForce(Spaceship ship, List<Planet> planets){
            float totalForce=0;
            foreach (Planet p in planets){
                float currForce = 0;
                float gravity = p.getGravity();
                float distance = p.getX()
            }
            return totalForce;
        }


    }
}
