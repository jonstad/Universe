using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universe
{
    class SolarSystem
    {
        List<Star> Start = new List<Star>();
        List<Planet> Planets = new List<Planet>();

        public string Name { get; set; }

        public SolarSystem()
        {
            Star mainstar = new Star();
            mainstar.SpectralC = SpectralClassification.G;
            mainstar.BaseMass = 10000;
            mainstar.Name = "Sun";




        }
        //Sun(s)(OBAFGKM)
        //Planets-Gassgiant(HotJUpiter,HotNepune,SubBrownStar,Chthonian), Solid(Gaia,Arid,Dry,Water,Ice,Lava,Pulsar)
        //Asteroid belt

    }
}
