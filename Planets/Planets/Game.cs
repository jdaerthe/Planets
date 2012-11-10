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
        
        public Game(MainPage page)
        {
            this.page = page;
            w = new World();
            w.setSpaceship(new Spaceship(new Vector(200, 0)));
            for (int i = 0; i < 10; i++) w.addPlanet(new Planet());
        }
        public void step(object s, object ev)
        {
            w.step();
            Graphics.update(page, w);
        }

        public void setup()
        {
            timer.Tick += new EventHandler<object>(step);
            timer.Interval = new TimeSpan(0, 0, 0, 0, 100);
            timer.Start();
            Graphics.drawWorld(page, w);
        }
        public World getWorld()
        {
            return w;
        }
    }
}
