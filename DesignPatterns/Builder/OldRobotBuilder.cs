// <copyright file="OldRobotBuilder.cs" company="Onno Invernizzi">
// Copyright (c) Onno Invernizzi. All rights reserved.
// </copyright>

namespace DesignPaterns.Builder
{
    /// <summary>
    /// Builds an old robot.
    /// </summary>
    /// <seealso cref="DesignPaterns.Builder.IRobotBuilder" />
    public class OldRobotBuilder : IRobotBuilder
    {
        /// <summary>
        /// A reference to the robot we're building.
        /// </summary>
        private readonly Robot robot;

        /// <summary>
        /// Initializes a new instance of the <see cref="OldRobotBuilder"/> class.
        /// </summary>
        public OldRobotBuilder()
        {
            this.robot = new Robot();
        }

        /// <summary>
        /// Builds the robot head.
        /// </summary>
        public void BuildRobotHead()
        {
            this.robot.Head = "Tin head";
        }

        /// <summary>
        /// Builds the robot torso.
        /// </summary>
        public void BuildRobotTorso()
        {
            this.robot.Torso = "Tin torso";
        }

        /// <summary>
        /// Builds the robot arms.
        /// </summary>
        public void BuildRobotArms()
        {
            this.robot.Arms = "Blowtorch arms";
        }

        /// <summary>
        /// Builds the robot legs.
        /// </summary>
        public void BuildRobotLegs()
        {
            this.robot.Legs = "Roller scates";
        }

        /// <summary>
        /// Gets the robot.
        /// </summary>
        /// <returns>A robot</returns>
        public Robot GetRobot()
        {
            return this.robot;
        }
    }
}
