using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planets
{
    class Element
    {
        private Vector position;
        private Vector lastposition;
        private float mass;

        public void setPosition(Vector p)
        {
            lastposition = position;
            position = p;
        }
        public Vector getPosition()
        {
            return position;
        }
        public void setX(float x)
        {
            this.lastposition.x = this.position.x;
            this.position.x = x;
        }
        public void setY(float y)
        {
            this.lastposition.y = this.position.y;
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
