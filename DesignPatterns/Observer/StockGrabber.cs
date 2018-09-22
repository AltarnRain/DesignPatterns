using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace DesignPaterns.Observer
{
    public class StockGrabber : ISubject
    {
        private readonly List<IObserver> observers;
        private double _ibmPrice;
        private double _aaplPrice;
        private double _googPrice;

        public double IbmPrice
        {
            get => _ibmPrice;
            set
            {
                _ibmPrice = value;
                this.NotifyObserver();
            }
        }


        public double AaplPrice
        {
            get => _aaplPrice;
            set
            {
                _aaplPrice = value;
                this.NotifyObserver();
            }
        }
        public double GoogPrice
        {
            get => _googPrice;
            set {
                _googPrice = value;
                this.NotifyObserver();
            }
        }


        public StockGrabber()
        {
            this.observers = new List<IObserver>();
        }

        public void NotifyObserver()
        {
            this.observers.ForEach(o => o.Update(this.IbmPrice, this.AaplPrice, this.GoogPrice));
        }

        public void Register(IObserver observer)
        {
            this.observers.Add(observer);
        }

        public void Unregister(IObserver observer)
        {

            var index = this.observers.IndexOf(observer);
            this.observers.RemoveAt(index);

            Console.WriteLine($"Overserver removed at index {index + 1}.");
            Console.WriteLine();
        }
    }
}
