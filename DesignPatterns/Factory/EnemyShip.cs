// <copyright file="EnemyShip.cs" company="Onno Invernizzi">
// Copyright (c) Onno Invernizzi. All rights reserved.
// </copyright>

namespace DesignPaterns.Factory
{
    using System;

    /// <summary>
    /// An abstract repentation of an enemy ship
    /// </summary>
    public abstract class EnemyShip
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the damage.
        /// </summary>
        /// <value>
        /// The damage.
        /// </value>
        public double Damage { get; set; }

        /// <summary>
        /// Follows the hero ship.
        /// </summary>
        public void FollowHeroShip()
        {
            Console.WriteLine(this.Name + " is following the hero");
        }

        /// <summary>
        /// Displays the enemy ship.
        /// </summary>
        public void DisplayEnemyShip()
        {
            Console.WriteLine(this.Name + " is on the screen");
        }

        /// <summary>
        /// Enemies the ship shoots.
        /// </summary>
        public void EnemyShipShoots()
        {
            Console.WriteLine(this.Name + " attacks and does " + this.Damage + " damage to hero");
        }
    }
}