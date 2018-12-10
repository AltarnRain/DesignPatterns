// <copyright file="TVRemote.cs" company="Onno Invernizzi">
// Copyright (c) Onno Invernizzi. All rights reserved.
// </copyright>

namespace DesignPaterns.Decorator.Commander
{
    /// <summary>
    /// Represents a TV Remote.
    /// </summary>
    public static class TVRemote
    {
        /// <summary>
        /// Gets the device.
        /// </summary>
        /// <returns>A Television</returns>
        public static IElectronicDevice GetDevice()
        {
            return new Television();
        }
    }
}
