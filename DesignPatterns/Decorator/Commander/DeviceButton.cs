// <copyright file="DeviceButton.cs" company="Onno Invernizzi">
// Copyright (c) Onno Invernizzi. All rights reserved.
// </copyright>

namespace DesignPaterns.Decorator.Commander
{
    /// <summary>
    /// Represents a button on a device.
    /// </summary>
    public class DeviceButton
    {
        /// <summary>
        /// The command
        /// </summary>
        private readonly ICommand command;

        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceButton"/> class.
        /// </summary>
        /// <param name="command">The command.</param>
        public DeviceButton(ICommand command)
        {
            this.command = command;
        }

        /// <summary>
        /// Presses a button.
        /// </summary>
        public void Press()
        {
            this.command.Execute();
        }
    }
}
