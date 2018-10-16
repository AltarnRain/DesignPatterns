// <copyright file="ItFlys.cs" company="Onno Invernizzi">
// Copyright (c) Onno Invernizzi. All rights reserved.
// </copyright>

namespace DesignPaterns.Strategy
{
    /// <summary>
    /// The class used if an animal can fly.
    /// </summary>
    /// <seealso cref="DesignPaterns.Strategy.IFlys" />
    public class ItFlys : IFlys
    {
        /// <summary>
        /// Returns the result of a flight action from a class that implements IFlys
        /// </summary>
        /// <returns>
        /// The result of a fly attempt
        /// </returns>
        public string Fly()
        {
            return "Flying High";
        }
    }
}