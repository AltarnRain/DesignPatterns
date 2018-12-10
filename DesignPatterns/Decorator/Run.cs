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
            var basicPizza = new Mozzerella(new TomatoSauce(new PlainPizza()));

            System.Console.WriteLine(basicPizza.Description);
            System.Console.WriteLine(basicPizza.Price);
        }
    }
}
