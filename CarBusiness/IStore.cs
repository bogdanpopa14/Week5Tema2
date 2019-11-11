using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBusiness
{
    public interface IStore
    {
        string Name { get; }
        
        IOrder ClientBuyCar(IPerson person, string car);
        void CancelOrder(IPerson person, IOrder order);
    }
}
