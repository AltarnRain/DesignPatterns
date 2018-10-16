// <copyright file="ISubject.cs" company="Onno Invernizzi">
// Copyright (c) Onno Invernizzi. All rights reserved.
// </copyright>

namespace DesignPaterns.Observer
{
    /// <summary>
    /// A subject.
    /// </summary>
    public interface ISubject
    {
        /// <summary>
        /// Registers the specified observer.
        /// </summary>
        /// <param name="observer">The observer.</param>
        void Register(IObserver observer);

        /// <summary>
        /// Unregisters the specified observer.
        /// </summary>
        /// <param name="observer">The observer.</param>
        void Unregister(IObserver observer);

        /// <summary>
        /// Notifies the observer.
        /// </summary>
        void NotifyObserver();
    }
}
