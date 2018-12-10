// <copyright file="PlainPizza.cs" company="Onno Invernizzi">
// Copyright (c) Onno Invernizzi. All rights reserved.
// </copyright>

namespace DesignPaterns.Decorator
{
    /// <summary>
    /// A plain pizza.
    /// </summary>
    /// <seealso cref="DesignPaterns.Decorator.IPizza" />
    public class PlainPizza : IPizza
    {
        /// <summary>
        /// Gets the description for a plain pizza..
        /// </summary>
        /// <value>
        /// The description.
        /// </value>
        public string Description => "Thin Dough";

        /// <summary>
        /// Gets the price for the price of a plain pizza.
        /// </summary>
        /// <value>
        /// The price.
        /// </value>
        public double Price => 4.00;
    }
}
