using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPaterns.Observer
{
    public interface IObserver
    {
        void Update(double ibmPrice, double applPrice, double googPrice);

    }
}
