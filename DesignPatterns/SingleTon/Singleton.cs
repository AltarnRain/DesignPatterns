using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace DesignPaterns.SingleTon
{
    public class Singleton
    {
        private static Singleton singleton = null;

        private static int instanceCount = 0;

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

        private static bool firstThread = true;

        private Singleton()
        {
            // no implementation.
        }

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

        public int InstanceCount
        {
            get
            {
                return instanceCount;
            }
        }

        public List<string> GetLetterList()
        {
            return letters;
        }

        public List<string> GetTiles(int howManyTiles)
        {
            var returnValue = new List<string>();

            // Generate a seed using a guid.
            var seed = Guid.NewGuid().ToString().Select(c => (int)c).Sum();

            var randomTilePicker = new Random(seed);

            for (var i = 0; i < howManyTiles; i++)
            {
                var randomTile = randomTilePicker.Next(0, letters.Count - 1);
                var letter = letters.ElementAt(randomTile);
                returnValue.Add(letter);
                letters.RemoveAt(randomTile);
            }

            return returnValue;
        }
    }
}
