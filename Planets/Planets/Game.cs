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
        private DispatcherTimer timer = new DispatcherTimer();
        
        public Game()
        {
            w = new World();
            w.setSpaceship(new Spaceship(new Vector(200, 0)));
        }
        public void step(object s, object ev)
        {
            w.step();
            Graphics.drawWorld(w);
        }

        public void setup()
        {
            timer.Tick += new EventHandler<object>(step);
            timer.Interval = new TimeSpan(0, 0, 0, 0, 100);
            timer.Start();
        }
        public World getWorld()
        {
            return w;
        }
    }
}
