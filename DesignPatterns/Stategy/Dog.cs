// <copyright file="Dog.cs" company="Onno Invernizzi">
// Copyright (c) Onno Invernizzi. All rights reserved.
// </copyright>

namespace DesignPaterns.Strategy
{
    using System;

    /// <summary>
    /// A Dog
    /// </summary>
    /// <seealso cref="DesignPaterns.Strategy.Animal" />
    public class Dog : Animal
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Dog" /> class.
        /// </summary>
        public Dog()
            : base()
        {
            this.Sound = "Bark";

            // We set the Flys interface polymorphically
            // This sets the behavior as a non-flying Animal
            this.FlyingType = new CantFly();
        }

        /// <summary>
        /// Digs the hole.
        /// </summary>
        public void DigHole()
        {
            Console.WriteLine("Dug a hole");
        }
    }
}