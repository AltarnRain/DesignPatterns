// <copyright file="Mozzerella.cs" company="Onno Invernizzi">
// Copyright (c) Onno Invernizzi. All rights reserved.
// </copyright>

namespace DesignPaterns.Decorator
{
    using System;

    /// <summary>
    /// Class for mozzerella topping.
    /// </summary>
    public class Mozzerella : ToppingDecorator
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Mozzerella"/> class.
        /// </summary>
        /// <param name="newPizza">The pizza.</param>
        public Mozzerella(IPizza newPizza)
            : base(newPizza)
        {
            Console.WriteLine("Adding dough");
            Console.WriteLine("Adding moz");
        }

        /// <summary>
        /// Gets the description.
        /// </summary>
        /// <value>
        /// The description.
        /// </value>
        public override string Description
        {
            get
            {
                return this.Pizza.Description + ", Mozzerella";
            }
        }

        /// <summary>
        /// Gets the price.
        /// </summary>
        /// <value>
        /// The cost.
        /// </value>
        public override double Price
        {
            get
            {
                return this.Pizza.Price + 0.50;
            }
        }
    }
}
