﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planets
{
    class Spaceship
    {
        private Vector position;
        private float mass;

        public Spaceship()
        {

        }
        public Spaceship(Vector p)
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
        public void setX(int x)
        {
            this.position.x = x;
        }
        public void setY(int y)
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
