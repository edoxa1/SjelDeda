using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SjelDeda
{
    class SuperEngine : IEngine
    {
        public SuperEngine()
        {
            Mass = 1000;
            Weight = 500;
            Power = 1500;
        }
        
        public void Start()
        {
            Console.WriteLine($"{ System.DateTime.Now} | Start; SuperEngine.cs");
        }
        public void Stop()
        {
            Console.WriteLine($"{System.DateTime.Now} | Stop; SuperEngine.cs");
        }
        public int Mass { get; set; }
        public int Weight { get; set; }
        public int Power { get; set; }
    }
}
