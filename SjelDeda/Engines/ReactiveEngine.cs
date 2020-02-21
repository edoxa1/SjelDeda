using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SjelDeda
{
    class ReactiveEngine : IEngine
    {
        public ReactiveEngine()
        {
            Mass = 1000;
            Weight = 570;
            Power = 1200;
        }
        public void Start()
        {
            Console.WriteLine($"{ System.DateTime.Now} | Start; ReactiveEngine.cs");
        }
        public void Stop()
        {
            Console.WriteLine($"{System.DateTime.Now} | Stop; ReactiveEngine.cs");
        }
        public int Mass { get; set; }
        public int Weight { get; set; }
        public int Power { get; set; }
    }
}
