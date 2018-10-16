// <copyright file="Bird.cs" company="Onno Invernizzi">
// Copyright (c) Onno Invernizzi. All rights reserved.
// </copyright>

namespace DesignPaterns.Strategy
{
    /// <summary>
    /// A bird
    /// </summary>
    /// <seealso cref="DesignPaterns.Strategy.Animal" />
    public class Bird : Animal
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Bird"/> class.
        /// </summary>
        public Bird()
            : base()
        {
            this.Sound = "Tweet";

            // We set the Flys interface polymorphically
            // This sets the behavior as a non-flying Animal
            this.FlyingType = new ItFlys();
        }
    }
}