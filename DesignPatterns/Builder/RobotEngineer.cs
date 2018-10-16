// <copyright file="RobotEngineer.cs" company="Onno Invernizzi">
// Copyright (c) Onno Invernizzi. All rights reserved.
// </copyright>

namespace DesignPaterns.Builder
{
    /// <summary>
    /// Engineers the robot. Also known as a director.
    /// </summary>
    public class RobotEngineer
    {
        /// <summary>
        /// The robot builder.
        /// </summary>
        private readonly IRobotBuilder robotBuilder;

        /// <summary>
        /// Initializes a new instance of the <see cref="RobotEngineer" /> class.
        /// </summary>
        /// <param name="robotBuilder">The robot builder.</param>
        public RobotEngineer(IRobotBuilder robotBuilder)
        {
            this.robotBuilder = robotBuilder;
        }

        /// <summary>
        /// Gets the robot.
        /// </summary>
        /// <returns>The build robot.</returns>
        public Robot GetRobot()
        {
            return this.robotBuilder.GetRobot();
        }

        /// <summary>
        /// Makes the robot by calling the methods from a robot builder.
        /// </summary>
        public void MakeRobot()
        {
            this.robotBuilder.BuildRobotHead();
            this.robotBuilder.BuildRobotTorso();
            this.robotBuilder.BuildRobotArms();
            this.robotBuilder.BuildRobotLegs();
        }
    }
}
