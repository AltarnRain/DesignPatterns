// <copyright file="Run.cs" company="Onno Invernizzi">
// Copyright (c) Onno Invernizzi. All rights reserved.
// </copyright>

namespace DesignPaterns.Observer
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// Runs the Observer pattern tutorial code.
    /// </summary>
    [TestClass]
    public class Run
    {
        /// <summary>
        /// Runs the observer pattern.
        /// </summary>
        [TestMethod]
        public void RunObserverPattern()
        {
            var stockGrabber = new StockGrabber();
            var stockObererver1 = new StockObserver(stockGrabber);

            stockGrabber.IbmPrice = 197.00;
            stockGrabber.AaplPrice = 677.60;
            stockGrabber.GoogPrice = 676.40;

            var stockObererver2 = new StockObserver(stockGrabber);

            stockGrabber.IbmPrice = 197.00;
            stockGrabber.AaplPrice = 677.60;
            stockGrabber.GoogPrice = 676.40;

            stockGrabber.Unregister(stockObererver1);

            stockGrabber.IbmPrice = 197.00;
            stockGrabber.AaplPrice = 677.60;
            stockGrabber.GoogPrice = 676.40;
        }
    }
}
