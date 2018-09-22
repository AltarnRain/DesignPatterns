using System;

namespace DesignPaterns.Observer
{
    public class StockObserver : IObserver
    {
        private double ibmPrice;
        private double aaplPrice;
        private double googPrice;

        private static int observerIdTracker = 0;

        private readonly int observerId;

        private readonly ISubject stockGrabber;

        public StockObserver(ISubject stockGrabber)
        {
            this.stockGrabber = stockGrabber;
            this.observerId = ++observerIdTracker;

            Console.WriteLine($"New Observer {this.observerId}");
            Console.WriteLine();

            this.stockGrabber.Register(this);
        }

        public void Update(double ibmPrice, double aaplPrice, double googPrice)
        {
            this.ibmPrice = ibmPrice;
            this.aaplPrice = aaplPrice;
            this.googPrice = googPrice;

            PrintThePrices();
        }

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
