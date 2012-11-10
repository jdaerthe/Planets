using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Xaml.Shapes;

namespace Planets
{
    class Graphics
    {
        
        public static void drawWorld(GamePlay page, World w)
        {
            List<Planet> planets = w.getPlanets();
            for (int i = 0; i < planets.Count; i++) page.ContentPanel1.Children.Add(planets[i].ellipse);
            page.ContentPanel1.Children.Add(w.getSpaceship().image);
        }
        public static void update(GamePlay page, World w)   
        {
            Spaceship ship = w.getSpaceship();
            ship.image.Margin = new Thickness(ship.getPosition().x, ship.getPosition().y, 0, 0);
            ship.image.RenderTransform = new RotateTransform() { Angle = 180*Math.Atan(ship.velocity.x / -ship.velocity.y) / Math.PI };
        }
    }
}
