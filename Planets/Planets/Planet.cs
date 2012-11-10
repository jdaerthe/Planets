using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;

namespace Planets
{
    class Planet
    {
        private Vector position;
        private float mass;
        private Color color;

        public Planet()
        {
            Random random = new Random();
            color = Color.FromArgb((byte)0xff,(byte)random.Next(0, 255), (byte)random.Next(0, 255), (byte)random.Next(0, 255));

        }
        public Planet(Vector p)
        {
            position = p;
        }
        public void setPosition(Vector p)
        {
            position = p;
        }
        public Vector getPosition()
        {
            return position;
        }
        public void setX(float x)
        {
            this.position.x = x;
        }
        public void setY(float y)
        {
            this.position.y = y;
        }
        public float getX()
        {
            return position.x;
        }
        public float getY()
        {
            return position.y;
        }
        public void setMass(float m)
        {
            mass = m;
        }
        public float getMass()
        {
            return mass;
        }
    }
}
