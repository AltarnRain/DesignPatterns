// <copyright file="BigUFOEnemyShip.cs" company="Onno Invernizzi">
// Copyright (c) Onno Invernizzi. All rights reserved.
// </copyright>

namespace DesignPaterns.Factory
{
    /// <summary>
    /// A Big UFO
    /// </summary>
    /// <seealso cref="DesignPaterns.Factory.UFOEnemyShip" />
    public class BigUFOEnemyShip : UFOEnemyShip
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BigUFOEnemyShip" /> class.
        /// </summary>
        public BigUFOEnemyShip()
        {
            this.Name = "Big UFO Enemy Ship";
            this.Damage = 40.0;
        }
    }
}