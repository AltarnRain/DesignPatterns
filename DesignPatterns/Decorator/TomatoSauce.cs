// <copyright file="TomatoSauce.cs" company="Onno Invernizzi">
// Copyright (c) Onno Invernizzi. All rights reserved.
// </copyright>

namespace DesignPaterns.Decorator
{
    using System;

    /// <summary>
    /// Class for mozzerella topping.
    /// </summary>
    public class TomatoSauce : ToppingDecorator
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TomatoSauce"/> class.
        /// </summary>
        /// <param name="newPizza">The pizza.</param>
        public TomatoSauce(IPizza newPizza)
            : base(newPizza)
        {
            Console.WriteLine("Adding tomato source");
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
                return this.Pizza.Description + ", sauce";
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
                return this.Pizza.Price + 0.35;
            }
        }
    }
}
