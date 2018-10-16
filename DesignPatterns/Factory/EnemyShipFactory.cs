// <copyright file="EnemyShipFactory.cs" company="Onno Invernizzi">
// Copyright (c) Onno Invernizzi. All rights reserved.
// </copyright>

namespace DesignPaterns.Factory
{
    /// <summary>
    /// A factory class that makes enemy ships
    /// </summary>
    public class EnemyShipFactory
    {
        /// <summary>
        /// Makes the enemy ship.
        /// </summary>
        /// <param name="newShipType">New type of the ship.</param>
        /// <returns>An enemy ship</returns>
        public EnemyShip MakeEnemyShip(string newShipType)
        {
            if (newShipType.Equals("U"))
            {
                return new UFOEnemyShip();
            }
            else if (newShipType.Equals("R"))
            {
                return new RocketEnemyShip();
            }
            else if (newShipType.Equals("B"))
            {
                return new BigUFOEnemyShip();
            }
            else
            {
                return null;
            }
        }
    }
}