using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universe
{
    class SolarSystem
    {
        public List<Star> Stars = new List<Star>();
        public List<Planet> Planets = new List<Planet>();

        public string Name { get; set; }

        public SolarSystem()
        {
            GStar mainstar = new GStar();
            mainstar.SpectralC = SpectralClassification.G;
            mainstar.BaseMass = 10000;
            mainstar.Name = "Sun";
            Stars.Add(mainstar);

            

        }
        //Sun(s)(OBAFGKM)
        //Planets-Gassgiant(HotJUpiter,HotNepune,SubBrownStar,Chthonian), Solid(Gaia,Arid,Dry,Water,Ice,Lava,Pulsar)
        //Asteroid belt

    }
}
