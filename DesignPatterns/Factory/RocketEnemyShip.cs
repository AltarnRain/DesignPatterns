// <copyright file="RocketEnemyShip.cs" company="Onno Invernizzi">
// Copyright (c) Onno Invernizzi. All rights reserved.
// </copyright>

namespace DesignPaterns.Factory
{
    /// <summary>
    /// A rocket!
    /// </summary>
    /// <seealso cref="DesignPaterns.Factory.EnemyShip" />
    public class RocketEnemyShip : EnemyShip
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RocketEnemyShip"/> class.
        /// </summary>
        public RocketEnemyShip()
        {
            this.Name = "Rocket Enemy Ship";
            this.Damage = 10.0;
        }
    }
}