namespace DesignPaterns.Factory
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;

    [TestClass]
    public class Run
    {

        [TestMethod]
        public void RunFactoryPattern()
        {

            // Create the factory object
            var shipFactory = new EnemyShipFactory();

            // Enemy ship object
            EnemyShip theEnemy = null;

            var input = "U";

            theEnemy = shipFactory.MakeEnemyShip(input);

            if (theEnemy != null)
            {

                DoStuffEnemy(theEnemy);

            }
            else
            {
                Console.WriteLine("Please enter U, R, or B next time");
            }

            #region Comments
            /*
            EnemyShip theEnemy = null;

            // Old way of creating objects
            // When we use new we are not being dynamic

            EnemyShip ufoShip = new UFOEnemyShip();

            doStuffEnemy(ufoShip);

            Console.WriteLine("\n");

            // -----------------------------------------

            // This allows me to make the program more dynamic
            // It doesn't close the code from being modified
            // and that is bad!

            // Defines an input stream to watch: keyboard
            Scanner userInput = new Scanner(System.in);

            string enemyShipOption = "";

            Console.WriteLine("What type of ship? (U or R)");

            if (userInput.hasNextLine()){

                enemyShipOption = userInput.nextLine();

            }

            if (enemyShipOption == "U"){

                theEnemy = new UFOEnemyShip();


            } else 

            if (enemyShipOption == "R"){

                theEnemy = new RocketEnemyShip();

            } else {

                theEnemy = new BigUFOEnemyShip();

            }

            doStuffEnemy(theEnemy);

            // --------------------------------------------
            */
            #endregion
        }

        // Executes methods of the super class
        public static void DoStuffEnemy(EnemyShip anEnemyShip)
        {
            anEnemyShip.DisplayEnemyShip();
            anEnemyShip.FollowHeroShip();
            anEnemyShip.EnemyShipShoots();
        }
    }
}