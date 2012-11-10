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
        World w;
        private DispatcherTimer timer = new DispatcherTimer();
        public Game()
        {
            w = new World();
        }
        public void step()
        {
            
        }

        public void setup()
        {
            timer.Tick += new EventHandler<DispatcherTimer>(step);
            timer.Interval = new TimeSpan(00, 1, 1);
            timer.Start();
        }
    }
}
