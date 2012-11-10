using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 


namespace Planets
{
    class Physics
    {
        public static float getNetForce(Spaceship ship, List<Planet> planets){
            float totalForce=0;
            foreach (Planet p in planets){
                float currForce = 0;
                float gravity = forceOfGravity(ship, p);
                

            }
            return totalForce;
        }

        public static float forceOfGravity(Spaceship s,Planet p){
            return (p.getGravity() * p.getMass() * s.getMass())/(getDistance(s,p));
        }

        private float getDistance(Spaceship s, Planet p){
            return Math.Sqrt(Math.Pow(p.getX() - s.getX(), 2) + Math.Pow(p.getY() - s.getY(), 2));
        }


    }
}
