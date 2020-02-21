using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SjelDeda
{
    class CryEng : IEngine
    {

        public CryEng()
        {
            Weight = 322;
            Mass = 365;
            Power = 400;
        }
        public void Start()
        {
            Console.WriteLine($"{ System.DateTime.Now} | CryEng.cs");
        }
        public void Stop()
        {
            Console.WriteLine($"{System.DateTime.Now} | Мощность: 0. Произошел троллинг..... CryEng.cs");
        }
        public int Mass { get; set; }
        public int Weight { get; set; }
        public int Power { get; set; }
    }
}
