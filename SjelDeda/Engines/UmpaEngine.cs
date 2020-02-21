using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SjelDeda
{
    class UmpaEngine : IEngine
    {
        public UmpaEngine()
        {
            Mass = 1700;
            Weight = 500;
            Power = 120;
        }
        public void Start()
        {
            Console.WriteLine($"{ System.DateTime.Now} | Start; UmpaEngine.cs");
        }
        public void Stop()
        {
            Console.WriteLine($"{ System.DateTime.Now} | Stop; UmpaEngine.cs");
        }
        public int Mass { get; set; }
        public int Weight { get; set; }
        public int Power { get; set; }
    }
}
