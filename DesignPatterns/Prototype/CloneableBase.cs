// <copyright file="CloneableBase.cs" company="Onno Invernizzi">
// Copyright (c) Onno Invernizzi. All rights reserved.
// </copyright>

namespace DesignPaterns.Prototype
{
    using System;

    /// <summary>
    /// Base class for all clonable objects
    /// </summary>
    /// <seealso cref="System.ICloneable" />
    public abstract class CloneableBase : ICloneable
    {
        /*
        * The Clonable inteface works differently in .NET. It does not 'magically' provide a method
        * to clone an object and I found this solution on StackExchange.
        * Link: https://stackoverflow.com/questions/21116554/proper-way-to-implement-icloneable
        */

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Creates a new object that is a copy of the current instance.
        /// </summary>
        /// <returns>
        /// A new object that is a copy of this instance.
        /// </returns>
        public virtual object Clone()
        {
            // This method is enforced by the ICloneable interface.
            var clone = this.CreateClone();

            // Name is a property of the base class, so the Clone method has to set it.
            clone.Name = this.Name;
            return clone;
        }

        /// <summary>
        /// Creates the clone. This method is implemented by any deriving class and
        /// it is used to set all properties added to a deriving class.
        /// </summary>
        /// <returns>A clone</returns>
        protected abstract CloneableBase CreateClone();
    }
}
