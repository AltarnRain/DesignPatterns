// <copyright file="UFOEmenyShip.cs" company="Onno Invernizzi">
// Copyright (c) Onno Invernizzi. All rights reserved.
// </copyright>

namespace DesignPaterns.Factory
{
    /// <summary>
    /// A norma ufo enemy.
    /// </summary>
    /// <seealso cref="DesignPaterns.Factory.EnemyShip" />
    public class UFOEnemyShip : EnemyShip
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UFOEnemyShip"/> class.
        /// </summary>
        public UFOEnemyShip()
        {
            this.Name = "UFO Enemy Ship";
            this.Damage = 20.0;
        }
    }
}