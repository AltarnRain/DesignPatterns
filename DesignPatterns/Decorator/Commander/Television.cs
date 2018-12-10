// <copyright file="Television.cs" company="Onno Invernizzi">
// Copyright (c) Onno Invernizzi. All rights reserved.
// </copyright>

namespace DesignPaterns.Decorator.Commander
{
    /// <summary>
    /// A Television
    /// </summary>
    /// <seealso cref="DesignPaterns.Decorator.Commander.IElectronicDevice" />
    public class Television : IElectronicDevice
    {
        /// <summary>
        /// The volume
        /// </summary>
        private int volume;

        /// <summary>
        /// Turn the device on.
        /// </summary>
        public void On()
        {
            System.Console.WriteLine("TV On");
        }

        /// <summary>
        /// Turns the device off.
        /// </summary>
        public void Off()
        {
            System.Console.WriteLine("TV Off");
        }

        /// <summary>
        /// Turns the volumes up.
        /// </summary>
        public void VolumeUp()
        {
            this.volume++;
            System.Console.WriteLine($"TV volume is at {this.volume}");
        }

        /// <summary>
        /// Turn the volumes down.
        /// </summary>
        public void VolumeDown()
        {
            this.volume--;
            System.Console.WriteLine($"TV volume is at {this.volume}");
        }
    }
}
