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
        
        public World() {
            spaceship = new Spaceship();
            planets = new List<Planet>();
            Physics.getNetForce(spaceship, planets);
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
