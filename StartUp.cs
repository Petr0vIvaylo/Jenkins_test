using System;
using AnimalFarm.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
