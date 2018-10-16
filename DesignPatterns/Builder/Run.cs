// <copyright file="Run.cs" company="Onno Invernizzi">
// Copyright (c) Onno Invernizzi. All rights reserved.
// </copyright>

namespace DesignPaterns.Builder
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// Runs the builder design pattern tutorial.
    /// </summary>
    [TestClass]
    public class Run
    {
        /// <summary>
        /// Builds a robot.
        /// </summary>
        [TestMethod]
        public void RunBuilderPattern()
        {
            var robotBuilder = new OldRobotBuilder();
            var robotEngineer = new RobotEngineer(robotBuilder);

            robotEngineer.MakeRobot();
            var robot = robotEngineer.GetRobot();

            Console.WriteLine(robot.Head);
            Console.WriteLine(robot.Torso);
            Console.WriteLine(robot.Arms);
            Console.WriteLine(robot.Legs);
        }
    }
}
