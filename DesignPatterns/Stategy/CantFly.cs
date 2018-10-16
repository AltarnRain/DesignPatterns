// <copyright file="CantFly.cs" company="Onno Invernizzi">
// Copyright (c) Onno Invernizzi. All rights reserved.
// </copyright>

namespace DesignPaterns.Strategy
{
    /// <summary>
    /// A class defines the inability to fly.
    /// </summary>
    /// <seealso cref="IFlys" />
    public class CantFly : IFlys
    {
        /// <summary>
        /// Returns the result of a flight action from a class that implements IFlys
        /// </summary>
        /// <returns>
        /// The result of a fly attempt
        /// </returns>
        public string Fly()
        {
            return "I can't fly";
        }
    }
}