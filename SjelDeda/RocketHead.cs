using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SjelDeda
{
    class RocketHead
    {
        public int Astronaut { get; set; }

        public int MassShell { get; private set; }

        public RocketHead()
        {
            Astronaut = 5;
            MassShell = 4000;
        }
        public int GetWeight()
        {
            return Astronaut * 80 + MassShell;
        }
        public void sendMessage(string message)
        {
            Console.WriteLine($"{System.DateTime.Now} | {message}");
        }
    }
}
