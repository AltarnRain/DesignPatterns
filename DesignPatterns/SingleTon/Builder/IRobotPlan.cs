// <copyright file="IRobotPlan.cs" company="Onno Invernizzi">
// Copyright (c) Onno Invernizzi. All rights reserved.
// </copyright>

namespace DesignPaterns.SingleTon.Builder
{
    /// <summary>
    /// Defines the RobotPlan
    /// </summary>
    public interface IRobotPlan
    {
        /// <summary>
        /// Sets the robot head.
        /// </summary>
        /// <param name="head">The head.</param>
        void SetRobotHead(string head);

        /// <summary>
        /// Sets the robot torso.
        /// </summary>
        /// <param name="torso">The torso.</param>
        void SetRobotTorso(string torso);

        /// <summary>
        /// Sets the robot arms.
        /// </summary>
        /// <param name="arm">The arm.</param>
        void SetRobotArms(string arm);

        /// <summary>
        /// Sets the robot legs.
        /// </summary>
        /// <param name="legs">The legs.</param>
        void SetRobotLegs(string legs);
    }
}
