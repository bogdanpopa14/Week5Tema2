using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    public interface IStore
    {
        string Name { get; }
        Order ClientBuyCar(Customer client, string carName);
        void CancelOrder(Customer c, Order o);
        void OrderSituation();
    }
}
