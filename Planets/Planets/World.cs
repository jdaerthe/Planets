using System;
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
        private double time;
        private double timestep = 0.1;
        
        public World() {
            spaceship = new Spaceship();
            planets = new List<Planet>();
            
        }

        public void step()
        {
            time += timestep;
            spaceship.setPosition(Physics.getNextLocation(spaceship, planets, timestep));
        }

        public void setSpaceship(Spaceship s)
        {
            spaceship = s;
        }
        public void getSpaceship()
        {
            return spaceship;
        }

        public void addPlanet(Planet p)
        {
            planets.Add(p);
        }
    }
}
