using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;

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
            this.page = page;
            w = new World();
            w.setSpaceship(new Spaceship());
            for (int i = -5; i < 6; i++) w.addPlanet(new Planet(random, 30, 50, i));
        }
        public void step(object s, object ev)
        {
            w.step();
            Graphics.update(page, w);
        }

        public void setup()
        {
            timer.Tick += new EventHandler<object>(step);
            timer.Interval = new TimeSpan(0, 0, 0, 0, 5);
            timer.Start();
            Graphics.drawWorld(page, w);
        }
        public World getWorld()
        {
            return w;
        }
    }
}
