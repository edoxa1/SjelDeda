using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SjelDeda
{
    class Rocket
    {
        public RocketHead Head { get; set; }
        public IEngine CryEngine { get; set; }

        public IEngine UmpaEngine { get; set; }

        public IEngine ReactiveEngine { get; set; }
        
        public IEngine SuperEngine { get; set; }
        public int Weight { get { return Head.GetWeight() + CryEngine.Weight; } }

        

    }
}
