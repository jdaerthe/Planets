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
        private GamePlay page;
        public DispatcherTimer timer = new DispatcherTimer();
        private Random random;
        
        public Game(GamePlay page)
        {
            random = new Random();
            int minradius=70;
            int maxradius=150;
            this.page = page;
            w = new World(page, this);
            w.setSpaceship(new Spaceship());
            int ei = random.Next(0, 6);
            for (int i = 0; i < 7; i++) 
                if (ei != i) w.addPlanet(new Planet(random,minradius,maxradius, i));
                else w.addPlanet(new Planet(random,2*minradius,maxradius,i, true));
        }
        public void step(object s, object ev)
        {
            if (w.step())
            {
                timer.Stop();
            }
            else
            {
                Graphics.update(page, w);
            }
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
