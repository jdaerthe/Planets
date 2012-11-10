using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Input;

namespace Planets
{
    class Game
    {
        private World w;
        private MainPage page;
        private DispatcherTimer timer = new DispatcherTimer();
        private Random random;
        
        public Game(MainPage page)
        {
            random = new Random();
            int minradius=30;
            int maxradius=100;
            this.page = page;
            w = new World();
            w.setSpaceship(new Spaceship());
            for (int i = -5; i < 6; i++) w.addPlanet(new Planet(random,minradius,maxradius));
            w.addPlanet(new Planet(random,2*minradius,maxradius, true));
        }
        public void step(object s, object ev)
        {
            w.step();
            Graphics.update(page, w);
        }

        public void setup()
        {
            Graphics.drawWorld(page, w);
            page.Tapped += new TappedEventHandler(pageTapped_Tapped);
            
        }
        public World getWorld()
        {
            return w;
        }

        public void pageTapped_Tapped(object sender, TappedRoutedEventArgs e){
            Windows.Foundation.Point position = e.GetPosition(w.getSpaceship().image);
            w.getSpaceship().velocity=new Vector((float)position.X, (float)position.Y);

            timer.Tick += new EventHandler<object>(step);
            timer.Interval = new TimeSpan(0, 0, 0, 0, 10);
            timer.Start();
        }   
    }
}
