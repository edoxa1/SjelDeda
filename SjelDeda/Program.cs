using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SjelDeda
{
    class Program
    {
        public static int SpecialNasaMethod(int weight, int power)
        {
            return (weight / power) * 10 + 82;
        }
        static void Main(string[] args)
        {
            Rocket r = new Rocket();
            r.Head = new RocketHead();
            
            //------------------------------------------------------------------------//
            r.CryEngine = new CryEng();
            r.CryEngine.Start();
            for(int i = 0; i <= 5; i++)
            {
                r.Head.sendMessage($"Мощность: {i * r.CryEngine.Power * r.CryEngine.Mass}");
                System.Threading.Thread.Sleep(500);
            }
            r.CryEngine.Stop();
            Console.WriteLine("Мощность по спец. методу наса: " + SpecialNasaMethod(r.CryEngine.Weight + r.Head.GetWeight(), r.CryEngine.Mass));
            Console.WriteLine("");
            //------------------------------------------------------------------------//
            r.UmpaEngine = new UmpaEngine();
            r.UmpaEngine.Start();
            for (int i = 0; i <= 5; i++)
            {
                r.Head.sendMessage($"Мощность: {r.UmpaEngine.Power * r.UmpaEngine.Mass * i}");
                System.Threading.Thread.Sleep(500);
            }
            r.UmpaEngine.Stop();
            Console.WriteLine("Мощность по спец. методу наса: " + SpecialNasaMethod(r.UmpaEngine.Weight + r.Head.GetWeight(), r.UmpaEngine.Mass));
            Console.WriteLine("");
            //------------------------------------------------------------------------//
            r.ReactiveEngine = new ReactiveEngine();
            r.ReactiveEngine.Start();
            for (int i = 0; i <= 5; i++)
            {
                r.Head.sendMessage($"Мощность: {r.ReactiveEngine.Power * r.ReactiveEngine.Mass * i}");
                System.Threading.Thread.Sleep(500);
            }
            r.ReactiveEngine.Stop();
            Console.WriteLine("Мощность по спец. методу наса: " + SpecialNasaMethod(r.ReactiveEngine.Weight + r.Head.GetWeight(), r.ReactiveEngine.Mass));
            Console.WriteLine("");
            //------------------------------------------------------------------------//
            r.SuperEngine = new SuperEngine();
            r.SuperEngine.Start();
            for (int i = 0; i <= 5; i++)
            {
                r.Head.sendMessage($"Мощность: {r.SuperEngine.Power * r.SuperEngine.Mass * i}");
                System.Threading.Thread.Sleep(500);
            }
            r.SuperEngine.Stop();
            Console.WriteLine("Мощность по спец. методу наса: " + SpecialNasaMethod(r.SuperEngine.Weight + r.Head.GetWeight(), r.SuperEngine.Mass));
            Console.WriteLine("");
            Console.ReadKey();
        }
    }
}
