// <copyright file="Run.cs" company="Onno Invernizzi">
// Copyright (c) Onno Invernizzi. All rights reserved.
// </copyright>

namespace DesignPaterns.Decorator
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// Test class for running the Decorator pattern.
    /// </summary>
    [TestClass]
    public class Run
    {
        /// <summary>
        /// Runs the decorator pattern.
        /// </summary>
        [TestMethod]
        public void RunDecoratorPattern()
        {
            var pizza = new PlainPizza();
            var moz = new Mozzerella(pizza);
            var basicPizza = new TomatoSauce(moz);

            System.Console.WriteLine(basicPizza.Description);
            System.Console.WriteLine(basicPizza.Price);
        }
    }
}
