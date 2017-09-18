using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universe
{
    class GStar : Star
    {
        private int _massmultiplier = 5;
        public int realmass;
        public GStar()
        {
            
        }
        public int GetsSize()
        {
            return _massmultiplier * BaseMass;
        }
    }
    enum SpectralClassification { O,B,A,F,G,K,M };  
    class Star
    {
        public int BaseMass { get; set; }
        //public System.Drawing.Color Color { get; set; }
        public SpectralClassification SpectralC { get; set; }
        public string Name { get; set; }
    }

}