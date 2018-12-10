// <copyright file="ToppingDecorator.cs" company="Onno Invernizzi">
// Copyright (c) Onno Invernizzi. All rights reserved.
// </copyright>

namespace DesignPaterns.Decorator
{
    /// <summary>
    /// The topping decorator.
    /// </summary>
    public abstract class ToppingDecorator : IPizza
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ToppingDecorator" /> class.
        /// </summary>
        /// <param name="newPizza">The pizza.</param>
        public ToppingDecorator(IPizza newPizza)
        {
            this.Pizza = newPizza;
        }

        /// <summary>
        /// Gets the description.
        /// </summary>
        /// <value>
        /// The description.
        /// </value>
        public string Description => this.Pizza.Description;

        /// <summary>
        /// Gets the price.
        /// </summary>
        /// <value>
        /// The price.
        /// </value>
        public double Price => this.Pizza.Price;

        /// <summary>
        /// Gets or sets the temporary pizza
        /// </summary>
        /// <value>
        /// The temporary pizza.
        /// </value>
        protected IPizza Pizza { get; set; }
    }
}
