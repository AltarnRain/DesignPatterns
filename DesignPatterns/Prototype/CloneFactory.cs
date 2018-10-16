// <copyright file="CloneFactory.cs" company="Onno Invernizzi">
// Copyright (c) Onno Invernizzi. All rights reserved.
// </copyright>

namespace DesignPaterns.Prototype
{
    /// <summary>
    /// Creates a clone of a passed object.
    /// </summary>
    public class CloneFactory
    {
        /// <summary>
        /// Gets the clone.
        /// </summary>
        /// <typeparam name="T">Any type that derives from <see cref="CloneableBase"/></typeparam>
        /// <param name="cloneableBase">The cloneable base.</param>
        /// <returns>A clone of the passed object</returns>
        public T GetClone<T>(CloneableBase cloneableBase)
            where T : CloneableBase
        {
            // Derek uses a cast to re-type the object but I would prefer using a generic in this
            // situation. T can only be a class the derives from ClonableBase making it
            // much safer to use this factory.
            return (T)cloneableBase.Clone();
        }
    }
}
