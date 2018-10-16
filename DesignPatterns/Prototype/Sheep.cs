// <copyright file="Sheep.cs" company="Onno Invernizzi">
// Copyright (c) Onno Invernizzi. All rights reserved.
// </copyright>

namespace DesignPaterns.Prototype
{
    /// <summary>
    /// A clonable sheep
    /// </summary>
    /// <seealso cref="DesignPaterns.Prototype.CloneableBase" />
    public class Sheep : CloneableBase
    {
        /// <summary>
        /// Gets or sets the number.
        /// </summary>
        /// <value>
        /// The number.
        /// </value>
        public int Number { get; set; }

        /// <summary>
        /// Clones this instance.
        /// </summary>
        /// <returns>
        /// A cloned sheep
        /// </returns>
        public override object Clone()
        {
            // The object's name's been set by the base implementation.
            var clone = base.Clone();
            return clone;
        }

        /// <summary>
        /// Creates the clone.
        /// </summary>
        /// <returns>A new sheep</returns>
        protected override CloneableBase CreateClone()
        {
            // This method is called by the base class.
            var clonedSheep = new Sheep
            {
                Number = this.Number
            };

            return clonedSheep;
        }
    }
}
