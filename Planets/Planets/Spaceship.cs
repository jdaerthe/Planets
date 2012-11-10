using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.Storage;
using Windows.Storage.Streams;

namespace Planets
{
    class Spaceship
    {
        private Vector position;
        public Vector velocity;
        private Vector lastposition;
        public Image image;

        public Spaceship()
        {
            position = new Vector(0, (int)Window.Current.Bounds.Height - 100);
            velocity = new Vector(0, -1000);
            image = new Image();
            BitmapImage myBitmapImage = new BitmapImage();
            myBitmapImage.UriSource = new Uri("ms-appx:///Assets/Rocket.png");

            myBitmapImage.DecodePixelWidth = 50;
            image.Source = myBitmapImage;
            image.Margin = new Thickness(position.x, position.y, 0, 0);
            image.Stretch = Stretch.Fill;
            image.Height = 100;
            image.Width = 50;
        }
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
    }
}
