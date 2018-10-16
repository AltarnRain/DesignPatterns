// <copyright file="Animal.cs" company="Onno Invernizzi">
// Copyright (c) Onno Invernizzi. All rights reserved.
// </copyright>

namespace DesignPaterns.Strategy
{
    using System;

    /// <summary>
    /// The base animal class
    /// </summary>
    public class Animal
    {
        /// <summary>
        /// The weight
        /// </summary>
        private int weight;

        /// <summary>
        /// Gets or sets the sound.
        /// </summary>
        /// <value>
        /// The sound.
        /// </value>
        public string Sound { get; set; }

        /// <summary>
        /// Gets or sets the weight.
        /// </summary>
        /// <value>
        /// The weight.
        /// </value>
        public int Weight
        {
            get
            {
                return this.weight;
            }

            set
            {
                if (value > 0)
                {
                    this.weight = value;
                }
                else
                {
                    Console.WriteLine("Weight must be bigger than 0");
                }
            }
        }

        /// <summary>
        /// Gets or sets the type of the flying.
        /// </summary>
        /// <value>
        /// The type of the flying.
        /// </value>
        public IFlys FlyingType { get; set; }

        /// <summary>
        /// Tries to fly.
        /// </summary>
        /// <returns>The result of the flight attempt</returns>
        public string TryToFly()
        {
            return this.FlyingType.Fly();
        }
    }
}