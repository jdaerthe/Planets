﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Shapes;
using Windows.UI.Xaml.Media;

namespace Planets
{
    class Planet
    {
        private Vector position;
        public Ellipse ellipse;
        private float mass;
        private Color color;
        private float radius;

        //constructor, sets all variables for a planet
        public Planet(Random random, int minradius, int maxradius, int ylayer)
        {
            //color
            color = Color.FromArgb((byte)0xff,(byte)random.Next(0, 255), (byte)random.Next(0, 255), (byte)random.Next(0, 255));
            //radius
            radius = random.Next(minradius, maxradius);
            //position
            position = new Vector(random.Next(-(int)Window.Current.Bounds.Width, (int)Window.Current.Bounds.Width), ylayer * maxradius * 2);
            //mass
            mass = radius * 1000000;

            ellipse = new Ellipse();
            ellipse.Width = 2 * radius;
            ellipse.Height = 2 * radius;
            ellipse.Margin = new Thickness(position.x, position.y, 0, 0);
            ellipse.Fill = new SolidColorBrush(color);
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
