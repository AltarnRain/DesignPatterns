// <copyright file="Run.cs" company="Onno Invernizzi">
// Copyright (c) Onno Invernizzi. All rights reserved.
// </copyright>

namespace DesignPaterns.Factory
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// The the Factory pattern tutorial.
    /// </summary>
    [TestClass]
    public class Run
    {
        /// <summary>
        /// Runs the factory pattern.
        /// </summary>
        [TestMethod]
        public void RunFactoryPattern()
        {
            // Create the factory object
            var shipFactory = new EnemyShipFactory();
            var input = "U";

            var theEnemy = shipFactory.MakeEnemyShip(input);

            if (theEnemy != null)
            {
                DoStuffEnemy(theEnemy);
            }
            else
            {
                Console.WriteLine("Please enter U, R, or B next time");
            }
        }

        /// <summary>
        /// Does the stuff to the enemy.
        /// </summary>
        /// <param name="anEnemyShip">An enemy ship.</param>
        private static void DoStuffEnemy(EnemyShip anEnemyShip)
        {
            anEnemyShip.DisplayEnemyShip();
            anEnemyShip.FollowHeroShip();
            anEnemyShip.EnemyShipShoots();
        }
    }
}