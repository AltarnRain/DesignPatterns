// <copyright file="Run.cs" company="Onno Invernizzi">
// Copyright (c) Onno Invernizzi. All rights reserved.
// </copyright>

namespace DesignPaterns.Decorator.Commander
{
    using System.Collections.Generic;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// Runs the Command Pattern
    /// </summary>
    [TestClass]
    public class Run
    {
        /// <summary>
        /// Runs the command pattern.
        /// </summary>
        [TestMethod]
        public void RunCommandPattern()
        {
            var device = TVRemote.GetDevice();

            var turnTVOn = new TurnTVOn(device);
            var turnTVOff = new TurnTVOff(device);
            var turnTVUp = new TurnTVUp(device);
            var turnTVDown = new TurnTVDown(device);

            var onButton = new DeviceButton(turnTVOn);
            var offButton = new DeviceButton(turnTVOff);
            var upButton = new DeviceButton(turnTVUp);
            var downButton = new DeviceButton(turnTVDown);

            // Execute a series of button presses handler though a generic Execute method.
            var sequence = new List<DeviceButton>
            {
                onButton,
                upButton,
                upButton,
                upButton,
                downButton,
                offButton
            };

            sequence.ForEach(s => s.Press());
        }
    }
}
