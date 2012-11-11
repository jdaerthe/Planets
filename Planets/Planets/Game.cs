using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
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
    class Game
    {
        private World w;
        private GamePlay page;
        public DispatcherTimer timer = new DispatcherTimer();
        private Random random;
        public int score;
        
        public Game(GamePlay page)
        {
            random = new Random();
            score = 0;
            int minradius=70;
            int maxradius=150;
            this.page = page;
            w = new World(page, this);
            w.setSpaceship(new Spaceship());
<<<<<<< HEAD
            int ei = random.Next(0, 6);
            for (int i = 0; i < 7; i++) 
=======
<<<<<<< HEAD
            int ei = random.Next(0, 8);
            for (int i = 0; i < 9; i++) 
>>>>>>> 7395723aea8da5fff561b8e20616c6f37c826d7a
                if (ei != i) w.addPlanet(new Planet(random,minradius,maxradius, i));
                else w.addPlanet(new Planet(random,2*minradius,maxradius,i, true));
=======

            for (int i = 0; i < 10; i++) w.addPlanet(new Planet(random,minradius,maxradius, i));
            w.addPlanet(new Planet(random,2*minradius,maxradius,random.Next(0, 9), true));
>>>>>>> f629e5c28095f54b24d8872f88c38663475e65dc
        }
        public void step(object s, object ev)
        {
            switch (w.step())
            {
                case 0:
                    Graphics.update(page, w);
                    break;
                case 1:
                    timer.Stop();
                   /* Windows.Storage.ApplicationDataContainer localSettings = Windows.Storage.ApplicationData.Current.LocalSettings;
                    if (localSettings.Values["highscore"] == null) localSettings.Values["highscore"] = 0;
                    if ((int)localSettings.Values["highscore"] < score)
                    {
                        localSettings.Values["highscore"] = score;
                        page.HighScore1.IsOpen = true;
                    }*/
                    break;
                case 2:
                    timer.Stop();
                    score++;
                    for (int i = 0; i < page.ContentPanel1.Children.Count(); i++)
                    {
                        if (!(page.ContentPanel1.Children[i] is Popup) && !(page.ContentPanel1.Children[i] is TextBlock))
                        {
                            page.ContentPanel1.Children.RemoveAt(i--);
                        }
                    }
                    w = new World(page, this);
                    page.Score1.Text = "Score: " + score;
                    w.setSpaceship(new Spaceship());
                    int ei = random.Next(0, 6);
                    for (int i = 0; i < 7; i++) 
                        if (ei != i) w.addPlanet(new Planet(random,70,150, i));
                        else w.addPlanet(new Planet(random,2*70,150,i, true));
                    Graphics.drawWorld(page, w);
                    
                    break;

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
