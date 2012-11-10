using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;
using Windows.UI.Xaml;

namespace Planets
{
    class Planet
    {
        private Vector position;
        private float mass;
        private Color color;
        private float radius;

        //constructor, sets all variables for a planet
        public Planet()
        {
            Random random = new Random();
            //color
            color = Color.FromArgb((byte)0xff,(byte)random.Next(0, 255), (byte)random.Next(0, 255), (byte)random.Next(0, 255));
            //radius
            radius = random.Next(25, 200);
            //position
            position.x = random.Next(0, (int)Window.Current.Bounds.Width);
            position.y = random.Next(0, (int)Window.Current.Bounds.Height);
            //mass
            mass = radius;
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
        public Color getColor()
        {
            return color;
        }
    }
}
