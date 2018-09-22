using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading.Tasks;

namespace DesignPaterns.SingleTon
{
    [TestClass]
    public class Run
    {
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

        [TestMethod]
        public void RunSingletonMultiThread()
        {
            var singleTon = Singleton.GetInstance();

            Task getTiles = GetTiles();
            Task getTilesAgain = GetTiles();

            getTiles.Start();
            getTilesAgain.Start();

            getTiles.Wait();
            getTilesAgain.Wait();
        }

        private Task GetTiles()
        {
            return new Task(() =>
            {
                var singleTon = Singleton.GetInstance();

                var playerOneTiles = singleTon.GetTiles(7);

                Console.WriteLine();
                Console.WriteLine("Player one tiles");

                playerOneTiles.ForEach(l => Console.WriteLine(l));
            });
        }
    }
}
