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
        private DispatcherTimer timer = new DispatcherTimer();
        private Random random;
        
        public Game(GamePlay page)
        {
            random = new Random();
            int minradius=30;
            int maxradius=100;
            this.page = page;
            w = new World();
            w.setSpaceship(new Spaceship());
<<<<<<< HEAD
            int ei = random.Next(0, 8);
            for (int i = 0; i < 9; i++) 
                if (ei != i) w.addPlanet(new Planet(random,minradius,maxradius, i));
                else w.addPlanet(new Planet(random,2*minradius,maxradius,i, true));
=======

            for (int i = 0; i < 10; i++) w.addPlanet(new Planet(random,minradius,maxradius, i));
            w.addPlanet(new Planet(random,2*minradius,maxradius,random.Next(0, 9), true));
>>>>>>> f629e5c28095f54b24d8872f88c38663475e65dc
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
