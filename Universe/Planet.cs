using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universe
{
    class Ice:Planet
    {
        
    }
    class Dry : Planet
    {

    }
    class Arid : Planet
    {

    }
    class Terran : Planet
    {

    }
    class Planet
    {
        public int Mass { get; set; }
        public int Orbit { get; set; }
        public int Diameter { get; set; }
        public string Name { get; set; }
    }
}
