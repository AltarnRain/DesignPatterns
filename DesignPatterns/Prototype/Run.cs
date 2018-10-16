// <copyright file="Run.cs" company="Onno Invernizzi">
// Copyright (c) Onno Invernizzi. All rights reserved.
// </copyright>

namespace DesignPaterns.Prototype
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// Test class for running the prototype pattern.
    /// </summary>
    [TestClass]
    public class Run
    {
        /// <summary>
        /// Runs the prototype pattern.
        /// </summary>
        [TestMethod]
        public void RunPrototypePattern()
        {
            var factory = new CloneFactory();
            var sally = new Sheep
            {
                Name = "Sally",
                Number = 1
            };

            var dolly = factory.GetClone<Sheep>(sally);

            Console.WriteLine(sally.Name);
            Console.WriteLine(sally.Number);

            // The output should be exactly the same as the previous two outputs.
            Console.WriteLine(dolly.Name);
            Console.WriteLine(dolly.Number);

            // If sheepClone were a reference, sally's name should now be dolly.
            dolly.Name = "Dolly";

            // The output proves dolly is her own object.
            Console.WriteLine(sally.Name);
            Console.WriteLine(dolly.Name);
        }
    }
}
