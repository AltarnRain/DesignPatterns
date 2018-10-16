// <copyright file="IObserver.cs" company="Onno Invernizzi">
// Copyright (c) Onno Invernizzi. All rights reserved.
// </copyright>

namespace DesignPaterns.Observer
{
    /// <summary>
    /// An inteface for an observer.
    /// </summary>
    public interface IObserver
    {
        /// <summary>
        /// Updates the specified prices.
        /// </summary>
        /// <param name="ibmPrice">The ibm price.</param>
        /// <param name="applPrice">The appl price.</param>
        /// <param name="googPrice">The goog price.</param>
        void Update(double ibmPrice, double applPrice, double googPrice);
    }
}
