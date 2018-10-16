// <copyright file="IRobotBuilder.cs" company="Onno Invernizzi">
// Copyright (c) Onno Invernizzi. All rights reserved.
// </copyright>

namespace DesignPaterns.Builder
{
    /// <summary>
    /// The RobotBuilder. This class builds the robot.
    /// </summary>
    public interface IRobotBuilder
    {
        /// <summary>
        /// Builds the robot head.
        /// </summary>
        void BuildRobotHead();

        /// <summary>
        /// Builds the robot torso.
        /// </summary>
        void BuildRobotTorso();

        /// <summary>
        /// Builds the robot arms.
        /// </summary>
        void BuildRobotArms();

        /// <summary>
        /// Builds the robot legs.
        /// </summary>
        void BuildRobotLegs();

        /// <summary>
        /// Gets the robot.
        /// </summary>
        /// <returns>An instance of a robot.</returns>
        Robot GetRobot();
    }
}
