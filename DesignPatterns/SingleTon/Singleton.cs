// <copyright file="Singleton.cs" company="Onno Invernizzi">
// Copyright (c) Onno Invernizzi. All rights reserved.
// </copyright>

namespace DesignPaterns.SingleTon
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;

    /// <summary>
    /// A class demontrating the Singleton pattern.
    /// </summary>
    public class Singleton
    {
        /// <summary>
        /// The first thread
        /// </summary>
        private static bool firstThread = true;

        /// <summary>
        /// A reference to the singleton class.
        /// </summary>
        private static Singleton singleton = null;

        /// <summary>
        /// The instance count
        /// </summary>
        private static int instanceCount = 0;

        /// <summary>
        /// The letters
        /// </summary>
        private readonly List<string> letters = new List<string>
        {
             "a", "a", "a", "a", "a", "a", "a", "a", "a",
            "b", "b", "c", "c", "d", "d", "d", "d", "e", "e", "e", "e", "e",
            "e", "e", "e", "e", "e", "e", "e", "f", "f", "g", "g", "g", "h",
            "h", "i", "i", "i", "i", "i", "i", "i", "i", "i", "j", "k", "l",
            "l", "l", "l", "m", "m", "n", "n", "n", "n", "n", "n", "o", "o",
            "o", "o", "o", "o", "o", "o", "p", "p", "q", "r", "r", "r", "r",
            "r", "r", "s", "s", "s", "s", "t", "t", "t", "t", "t", "t", "u",
            "u", "u", "u", "v", "v", "w", "w", "x", "y", "y", "z"
        };

        /// <summary>
        /// Prevents a default instance of the <see cref="Singleton"/> class from being created.
        /// </summary>
        private Singleton()
        {
            // no implementation.
        }

        /// <summary>
        /// Gets the instance of <see cref="Singleton" />
        /// </summary>
        /// <returns>
        /// The same instance of singleton
        /// </returns>
        public static Singleton GetInstance()
        {
            if (singleton == null)
            {
                if (firstThread)
                {
                    firstThread = false;

                    Thread.Sleep(1000);
                }

                singleton = new Singleton();
                instanceCount++;
            }

            return singleton;
        }

        /// <summary>
        /// Gets the letter list.
        /// </summary>
        /// <returns>
        /// The letters
        /// </returns>
        public List<string> GetLetterList()
        {
            return this.letters;
        }

        /// <summary>
        /// Gets the tiles.
        /// </summary>
        /// <param name="howManyTiles">The how many tiles.</param>
        /// <returns>
        /// A random selection of tiles from letters
        /// </returns>
        public List<string> GetTiles(int howManyTiles)
        {
            var returnValue = new List<string>();

            // Generate a seed using a guid.
            var seed = Guid.NewGuid().ToString().Select(c => (int)c).Sum();

            var randomTilePicker = new Random(seed);

            for (var i = 0; i < howManyTiles; i++)
            {
                var randomTile = randomTilePicker.Next(0, this.letters.Count - 1);
                var letter = this.letters.ElementAt(randomTile);
                returnValue.Add(letter);
                this.letters.RemoveAt(randomTile);
            }

            return returnValue;
        }
    }
}
