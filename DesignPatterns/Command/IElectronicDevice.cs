// <copyright file="IElectronicDevice.cs" company="Onno Invernizzi">
// Copyright (c) Onno Invernizzi. All rights reserved.
// </copyright>

namespace DesignPaterns.Decorator.Commander
{
    /// <summary>
    /// Interface for an electronic device.
    /// </summary>
    public interface IElectronicDevice
    {
        /// <summary>
        /// Turn the device on.
        /// </summary>
        void On();

        /// <summary>
        /// Turns the device off.
        /// </summary>
        void Off();

        /// <summary>
        /// Turns the volumes up.
        /// </summary>
        void VolumeUp();

        /// <summary>
        /// Turn the volumes down.
        /// </summary>
        void VolumeDown();
    }
}
