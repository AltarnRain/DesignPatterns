// <copyright file="IFlys.cs" company="Onno Invernizzi">
// Copyright (c) Onno Invernizzi. All rights reserved.
// </copyright>

namespace DesignPaterns.Strategy
{
    /// <summary>
    /// The IFyls interface.
    /// </summary>
    public interface IFlys
    {
        /// <summary>
        /// Returns the result of a flight action from a class that implements IFlys
        /// </summary>
        /// <returns>The result of a fly attempt</returns>
        string Fly();
    }
}