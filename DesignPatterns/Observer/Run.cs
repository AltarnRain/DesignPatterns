using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPaterns.Observer
{
    [TestClass]
    public class Run
    {
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
