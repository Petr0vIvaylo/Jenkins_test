using System;
using AnimalFarm.Core;

namespace AnimalFarm
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Engine engine = new Engine();
            engine.Run();
        }
    }
}
