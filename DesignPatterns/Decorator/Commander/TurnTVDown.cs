// <copyright file="TurnTVDown.cs" company="Onno Invernizzi">
// Copyright (c) Onno Invernizzi. All rights reserved.
// </copyright>

namespace DesignPaterns.Decorator.Commander
{
    /// <summary>
    /// Turns the TV on.
    /// </summary>
    public class TurnTVDown : ICommand
    {
        /// <summary>
        /// The electronic device
        /// </summary>
        private readonly IElectronicDevice electronicDevice;

        /// <summary>
        /// Initializes a new instance of the <see cref="TurnTVDown"/> class.
        /// </summary>
        /// <param name="electronicDevice">The electronic device.</param>
        public TurnTVDown(IElectronicDevice electronicDevice)
        {
            this.electronicDevice = electronicDevice;
        }

        /// <summary>
        /// Executes this instance.
        /// </summary>
        public void Execute()
        {
            this.electronicDevice.VolumeDown();
        }
    }
}
