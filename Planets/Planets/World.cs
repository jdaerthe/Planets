﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Xaml.Shapes;
using Windows.UI.Xaml.Media.Imaging;
using Windows.Storage;
using Windows.Storage.Streams;

namespace Planets
{
    class World
    {
        private Spaceship spaceship;
        private List<Planet> planets;
        private float time = 0;
        public static float timestep = 0.01f;
        public GamePlay game;
        public Game parent;

        public World(GamePlay page, Game parent) {
            planets = new List<Planet>();
            this.parent = parent;
            game = page;
        }
        public List<Planet> getPlanets()
        {
            return planets;
        }
        public int step()
        {
            time += timestep;
            Vector newpos = Physics.getNewPosition(spaceship, planets, timestep);
            if (newpos != null) spaceship.setPosition(newpos);
            else
            {
                foreach (Planet p in planets)
                {
                    if (p.isEarth && spaceship.getPosition().minus(p.getPosition()).getMagnitude() < p.radius + spaceship.image.ActualHeight)
                    {
                        youWin();
                        return 2;
                    }
                }
                youLose();
                return 1;
            }
            return 0;
        }

        public void youWin()
        {
            if (!game.YouWin1.IsOpen) { game.YouWin1.IsOpen = true; }
        }

        public void youLose()
        {
            if (!game.YouLose1.IsOpen) { game.YouLose1.IsOpen = true; }
        }

        public void setSpaceship(Spaceship s)
        {
            spaceship = s;
        }
        public Spaceship getSpaceship()
        {
            return spaceship;
        }

        public void addPlanet(Planet p)
        {
            planets.Add(p);
        }
        public float getTime()
        {
            return time;
        }
    }
}
