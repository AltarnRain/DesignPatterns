// <copyright file="Run.cs" company="Onno Invernizzi">
// Copyright (c) Onno Invernizzi. All rights reserved.
// </copyright>

namespace DesignPaterns.Strategy
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// Runs the strategy pattern.
    /// </summary>
    [TestClass]
    public class Run
    {
        /// <summary>
        /// Runs the strategy pattern.
        /// </summary>
        [TestMethod]
        public void RunStrategyPattern()
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