using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Planets
{
    class Physics
    {
        //get a new position based on ship and planets configurations
        public static Vector getNewPosition(Spaceship ship, List<Planet> planets, float time)
        {
            Vector acc = new Vector(0, 0);
            foreach (Planet p in planets){
                acc = acc.plus(getAcceleration(ship, p));
            }
            ship.velocity = ship.velocity.plus(acc.times(time));
            return ship.getPosition().plus(ship.velocity.times(time));
        }

        //helper to get distance between two objects
        private static float getDistance(Spaceship s, Planet p){
            return (float)Math.Sqrt((float)Math.Pow(p.getX() - s.getX(), 2) + (float)Math.Pow(p.getY() - s.getY(), 2));
        }

        //helper to get x acceleration
        private static float Xacceleration(Spaceship s, Planet p)
        {
            return p.getMass() * (p.getX() - s.getX()) / (float)Math.Pow(getDistance(s, p), 3);
        }

        //helper to get y acceleration
        private static float Yacceleration(Spaceship s, Planet p)
        {
            return p.getMass() * (p.getY() - s.getY()) / (float)Math.Pow(getDistance(s, p), 3);
        }
        private static Vector getAcceleration(Spaceship s, Planet p)
        {
            Vector distance = p.getPosition().minus(s.getPosition());
            float d3 = (float)Math.Pow(distance.getMagnitude(), 3);
            return distance.times(p.getMass() / d3);
        }


    }
}
