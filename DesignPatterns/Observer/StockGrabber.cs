// <copyright file="StockGrabber.cs" company="Onno Invernizzi">
// Copyright (c) Onno Invernizzi. All rights reserved.
// </copyright>

namespace DesignPaterns.Observer
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// A stock grabber.
    /// </summary>
    /// <seealso cref="DesignPaterns.Observer.ISubject" />
    public class StockGrabber : ISubject
    {
        /// <summary>
        /// The observers
        /// </summary>
        private readonly List<IObserver> observers;

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
        /// Initializes a new instance of the <see cref="StockGrabber" /> class.
        /// </summary>
        public StockGrabber()
        {
            this.observers = new List<IObserver>();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StockGrabber"/> class.
        /// </summary>
        /// <param name="observers">The observers.</param>
        /// <param name="ibmPrice">The ibm price.</param>
        /// <param name="aaplPrice">The aapl price.</param>
        /// <param name="googPrice">The goog price.</param>
        public StockGrabber(List<IObserver> observers, double ibmPrice, double aaplPrice, double googPrice)
        {
            this.observers = observers;
            this.ibmPrice = ibmPrice;
            this.aaplPrice = aaplPrice;
            this.googPrice = googPrice;
        }

        /// <summary>
        /// Gets or sets the IBM stock price.
        /// </summary>
        /// <value>
        /// The ibm price.
        /// </value>
        public double IbmPrice
        {
            get => this.ibmPrice;
            set
            {
                this.ibmPrice = value;
                this.NotifyObserver();
            }
        }

        /// <summary>
        /// Gets or sets the Apple stick price.
        /// </summary>
        /// <value>
        /// The aapl price.
        /// </value>
        public double AaplPrice
        {
            get => this.aaplPrice;
            set
            {
                this.aaplPrice = value;
                this.NotifyObserver();
            }
        }

        /// <summary>
        /// Gets or sets the Google stock price.
        /// </summary>
        /// <value>
        /// The goog price.
        /// </value>
        public double GoogPrice
        {
            get => this.googPrice;
            set
            {
                this.googPrice = value;
                this.NotifyObserver();
            }
        }

        /// <summary>
        /// Notifies the all registered observers.
        /// </summary>
        public void NotifyObserver()
        {
            this.observers.ForEach(o => o.Update(this.IbmPrice, this.AaplPrice, this.GoogPrice));
        }

        /// <summary>
        /// Registers the specified observer.
        /// </summary>
        /// <param name="observer">The observer.</param>
        public void Register(IObserver observer)
        {
            this.observers.Add(observer);
        }

        /// <summary>
        /// Unregisters the specified observer.
        /// </summary>
        /// <param name="observer">The observer.</param>
        public void Unregister(IObserver observer)
        {
            var index = this.observers.IndexOf(observer);
            this.observers.RemoveAt(index);

            Console.WriteLine($"Overserver removed at index {index + 1}.");
            Console.WriteLine();
        }
    }
}
