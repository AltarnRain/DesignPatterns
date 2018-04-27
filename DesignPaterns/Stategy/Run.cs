using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DesignPaterns.Strategy
{
    [TestClass]
    public class Run
    {
        [TestMethod]
        public void RunDemo()
        {
            var sparky = new Dog();
            var tweety = new Bird();

            Console.WriteLine("Dog: " + sparky.TryToFly());
            Console.WriteLine("Bird: " + tweety.TryToFly());

            // This allows dynamic changes for flyingType
            sparky.FlyingType = new ItFlys();

            Console.WriteLine("Dog: " + sparky.TryToFly());
        }
    } 
}