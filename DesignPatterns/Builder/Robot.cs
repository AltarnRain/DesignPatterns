// <copyright file="Robot.cs" company="Onno Invernizzi">
// Copyright (c) Onno Invernizzi. All rights reserved.
// </copyright>

namespace DesignPaterns.Builder
{
    /// <summary>
    /// The Robot.
    /// </summary>
    /// <seealso cref="DesignPaterns.Builder.IRobotPlan" />
    /// <seealso cref="IRobotPlan" />
    public class Robot : IRobotPlan
    {
        /// <summary>
        /// Gets or sets the robot head.
        /// </summary>
        /// <value>
        /// The robot head.
        /// </value>
        public string Head { get; set; }

        /// <summary>
        /// Gets or sets the robot torso.
        /// </summary>
        /// <value>
        /// The robot torso.
        /// </value>
        public string Torso { get; set; }

        /// <summary>
        /// Gets or sets the robot arms.
        /// </summary>
        /// <value>
        /// The robot arms.
        /// </value>
        public string Arms { get; set; }

        /// <summary>
        /// Gets or sets the robot legs.
        /// </summary>
        /// <value>
        /// The robot legs.
        /// </value>
        public string Legs { get; set; }
    }
}
