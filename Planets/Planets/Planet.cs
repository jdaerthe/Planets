﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Shapes;
<<<<<<< HEAD
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.Storage;
using Windows.Storage.Streams;
=======
using Windows.UI.Xaml.Media;
>>>>>>> f629e5c28095f54b24d8872f88c38663475e65dc

namespace Planets
{
    class Planet
    {
        private Vector position;
        public Ellipse ellipse;
<<<<<<< HEAD
        public Image image = null;
=======
>>>>>>> f629e5c28095f54b24d8872f88c38663475e65dc
        private float mass;
        private Color color;
        public float radius;
        public bool isEarth;
<<<<<<< HEAD
        public static string[] images = {"mars.png", "jupiter.png", "venus.png", "moon.png", "mercury.png" };
=======
>>>>>>> f629e5c28095f54b24d8872f88c38663475e65dc

        //constructor, sets all variables for a planet
        public Planet(Random random, int minradius, int maxradius, int ylayer, bool isEarth=false)
        {
            //color
            color = Color.FromArgb((byte)0xff,(byte)random.Next(0, 255), (byte)random.Next(0, 255), (byte)random.Next(0, 255));
            //radius
            radius = random.Next(minradius, maxradius);
            //position
<<<<<<< HEAD
            position = new Vector(random.Next(-(int)Window.Current.Bounds.Width + (int)radius * 4, (int)Window.Current.Bounds.Width) - (int)radius * 4, -(int)Window.Current.Bounds.Height + radius * (2*ylayer + 2));
=======
            position = new Vector(random.Next(-(int)Window.Current.Bounds.Width + maxradius, (int)Window.Current.Bounds.Width) - maxradius, -(int)Window.Current.Bounds.Height + 200 * (ylayer - 1));
>>>>>>> f629e5c28095f54b24d8872f88c38663475e65dc
            //position = new Vector(random.Next(-(int)Window.Current.Bounds.Width, (int)Window.Current.Bounds.Width), random.Next(-(int)Window.Current.Bounds.Height + maxradius * 2, (int)Window.Current.Bounds.Height - maxradius * 2));
            //mass
             mass = radius * 5000000;
            //earth?
<<<<<<< HEAD
            this.isEarth = isEarth;
            if (isEarth)
            {
                image = new Image();
                BitmapImage myBitmapImage = new BitmapImage();
                myBitmapImage.UriSource = new Uri("ms-appx:///Assets/earth2.png");

                myBitmapImage.DecodePixelWidth = (int)radius * 2;
                image.Source = myBitmapImage;
                image.Margin = new Thickness(position.x, position.y, 0, 0);
                image.Stretch = Stretch.Fill;
                image.Height = (int)radius * 2;
                image.Width = (int)radius * 2;
            }
            else
            {
                image = new Image();
                BitmapImage myBitmapImage = new BitmapImage();
                string name = images[random.Next(0, images.Count())];
                myBitmapImage.UriSource = new Uri("ms-appx:///Assets/" + name);

                myBitmapImage.DecodePixelWidth = (int)radius * 2;
                image.Source = myBitmapImage;
                image.Margin = new Thickness(position.x, position.y, 0, 0);
                image.Stretch = Stretch.Fill;
                image.Height = (int)radius * 2;
                image.Width = (int)radius * 2;
            }
=======
            isEarth = this.isEarth;
            if (isEarth) color = Colors.White;
>>>>>>> f629e5c28095f54b24d8872f88c38663475e65dc

            ellipse = new Ellipse();
            ellipse.Width = 2 * radius;
            ellipse.Height = 2 * radius;
            ellipse.Margin = new Thickness(position.x, position.y, 0, 0);
<<<<<<< HEAD
            ellipse.StrokeThickness = 7.0;
            ellipse.Stroke = new SolidColorBrush(color);
=======
            ellipse.Fill = new SolidColorBrush(color);
>>>>>>> f629e5c28095f54b24d8872f88c38663475e65dc
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
