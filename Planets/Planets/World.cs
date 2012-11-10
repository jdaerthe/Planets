﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planets
{
    class World
    {
        private Spaceship spaceship;
        private List<Planet> planets;
        private float time = 0;
        private float timestep = 0.1f;
        
        public World() {
            planets = new List<Planet>();
            
        }

        public void step()
        {
            time += timestep;
            spaceship.setPosition(Physics.getNewPosition(spaceship, planets, timestep));
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
