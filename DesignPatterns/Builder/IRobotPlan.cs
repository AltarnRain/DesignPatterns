// <copyright file="IRobotPlan.cs" company="Onno Invernizzi">
// Copyright (c) Onno Invernizzi. All rights reserved.
// </copyright>

namespace DesignPaterns.Builder
{
    /// <summary>
    /// Defines the RobotPlan
    /// </summary>
    public interface IRobotPlan
    {
        /// <summary>
        /// Gets or sets the robot head.
        /// </summary>
        /// <value>
        /// The robot head.
        /// </value>
        string Head { get; set; }

        /// <summary>
        /// Gets or sets the robot torso.
        /// </summary>
        /// <value>
        /// The robot torso.
        /// </value>
        string Torso { get; set; }

        /// <summary>
        /// Gets or sets the robot arms.
        /// </summary>
        /// <value>
        /// The robot arms.
        /// </value>
        string Arms { get; set; }

        /// <summary>
        /// Gets or sets the robot legs.
        /// </summary>
        /// <value>
        /// The robot legs.
        /// </value>
        string Legs { get; set; }
    }
}
