// <copyright file="TurnTVOn.cs" company="Onno Invernizzi">
// Copyright (c) Onno Invernizzi. All rights reserved.
// </copyright>

namespace DesignPaterns.Decorator.Commander
{
    /// <summary>
    /// Turns the TV on.
    /// </summary>
    public class TurnTVOn : ICommand
    {
        /// <summary>
        /// The electronic device
        /// </summary>
        private readonly IElectronicDevice electronicDevice;

        /// <summary>
        /// Initializes a new instance of the <see cref="TurnTVOn"/> class.
        /// </summary>
        /// <param name="electronicDevice">The electronic device.</param>
        public TurnTVOn(IElectronicDevice electronicDevice)
        {
            this.electronicDevice = electronicDevice;
        }

        /// <summary>
        /// Executes this instance.
        /// </summary>
        public void Execute()
        {
            this.electronicDevice.On();
        }
    }
}
