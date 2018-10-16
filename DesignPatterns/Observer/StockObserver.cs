// <copyright file="StockObserver.cs" company="Onno Invernizzi">
// Copyright (c) Onno Invernizzi. All rights reserved.
// </copyright>

namespace DesignPaterns.Observer
{
    using System;

    /// <summary>
    /// A stock observer
    /// </summary>
    /// <seealso cref="IObserver" />
    public class StockObserver : IObserver
    {
        /// <summary>
        /// The observer identifier tracker
        /// </summary>
        private static int observerIdTracker = 0;

        /// <summary>
        /// The observer identifier
        /// </summary>
        private readonly int observerId;

        /// <summary>
        /// The stock grabber
        /// </summary>
        private readonly ISubject stockGrabber;

        /// <summary>
        /// The ibm price
        /// </summary>
        private double ibmPrice;

        /// <summary>
        /// The aapl price
        /// </summary>
        private double aaplPrice;

        /// <summary>
        /// The goog price
        /// </summary>
        private double googPrice;

        /// <summary>
        /// Initializes a new instance of the <see cref="StockObserver"/> class.
        /// </summary>
        /// <param name="stockGrabber">The stock grabber.</param>
        public StockObserver(ISubject stockGrabber)
        {
            this.stockGrabber = stockGrabber;
            this.observerId = ++observerIdTracker;

            Console.WriteLine($"New Observer {this.observerId}");
            Console.WriteLine();

            this.stockGrabber.Register(this);
        }

        /// <summary>
        /// Updates the specified ibm price.
        /// </summary>
        /// <param name="ibmPrice">The ibm price.</param>
        /// <param name="aaplPrice">The aapl price.</param>
        /// <param name="googPrice">The goog price.</param>
        public void Update(double ibmPrice, double aaplPrice, double googPrice)
        {
            this.ibmPrice = ibmPrice;
            this.aaplPrice = aaplPrice;
            this.googPrice = googPrice;

            this.PrintThePrices();
        }

        /// <summary>
        /// Prints the prices.
        /// </summary>
        private void PrintThePrices()
        {
            Console.WriteLine($"Observer id: {this.observerId}");
            Console.WriteLine($"IBM Price: {this.ibmPrice}");
            Console.WriteLine($"Apple price: {this.aaplPrice}");
            Console.WriteLine($"Google price: {this.googPrice}");
            Console.WriteLine();
        }
    }
}
