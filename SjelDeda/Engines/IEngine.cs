namespace SjelDeda
{
    interface IEngine
    {
        void Start();
        void Stop();
        int Weight { get; }
        int Mass { get; }
        int Power { get; }
    }
}
