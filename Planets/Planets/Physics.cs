using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Planets
{
    class Physics
    {
        public static Vector getNewPosition(Spaceship ship, List<Planet> planets, float time){
            float xAcc = 0;
            float yAcc = 0;
            foreach (Planet p in planets){
                xAcc += Xacceleration(ship, p);
                yAcc += Yacceleration(ship, p);
            }

            float xPos = xAcc * (float)Math.Pow(time, 2);
            float yPos = yAcc * (float)Math.Pow(time, 2);
            return new Vector(xPos,yPos);
        }

        public static float getGravity(Spaceship s,Planet p){
<<<<<<< HEAD
            return (p.getMass() * s.getMass())/(float)Math.Pow(getDistance(s,p),2);
=======
            return (p.getMass() * s.getMass())/Math.Pow(getDistance(s,p),2);
>>>>>>> 1ffac4b07aaa0ae2863efc6005d1ac4827db8a35
        }

        private static float getDistance(Spaceship s, Planet p){
            return (float)Math.Sqrt((float)Math.Pow(p.getX() - s.getX(), 2) + (float)Math.Pow(p.getY() - s.getY(), 2));
        }

        private static float Xacceleration(Spaceship s, Planet p)
        {
            return p.getMass() * (p.getX() - s.getX()) / (float)Math.Pow(getDistance(s, p), 3);
        }

        private static float Yacceleration(Spaceship s, Planet p)
        {
            return p.getMass() * (p.getY() - s.getY()) / (float)Math.Pow(getDistance(s, p), 3);
        }


    }
}
