// <copyright file="BigUFOEnemy.cs" company="Onno Invernizzi">
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
            this.SetName("Big UFO Enemy Ship");
            this.SetDamage(40.0);
        }
    }
}