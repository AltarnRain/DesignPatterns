// <copyright file="Run.cs" company="Onno Invernizzi">
// Copyright (c) Onno Invernizzi. All rights reserved.
// </copyright>

namespace DesignPaterns.SingleTon
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// Runs the Singleton design pattern tuturial
    /// </summary>
    [TestClass]
    public class Run
    {
        /// <summary>
        /// Runs the singleton in a single thread.
        /// </summary>
        [TestMethod]
        public void RunSingletonSingleThread()
        {
            var singleTon = Singleton.GetInstance();

            Console.WriteLine($"Remaining letters {singleTon.GetLetterList().Count}");
            singleTon.GetLetterList().ForEach(l => Console.WriteLine(l));

            var playerOneTiles = singleTon.GetTiles(7);

            Console.WriteLine();
            Console.WriteLine("Player one tiles");

            playerOneTiles.ForEach(l => Console.WriteLine(l));

            Console.WriteLine();
            Console.WriteLine($"Remaining letters {singleTon.GetLetterList().Count}");
            singleTon.GetLetterList().ForEach(l => Console.WriteLine(l));

            var playerTwoTiles = singleTon.GetTiles(7);
            Console.WriteLine();
            Console.WriteLine("Player two tiles");
            playerTwoTiles.ForEach(l => Console.WriteLine(l));
            Console.WriteLine();

            Console.WriteLine($"Remaining letters {singleTon.GetLetterList().Count}");
            singleTon.GetLetterList().ForEach(l => Console.WriteLine(l));
        }
    }
}
