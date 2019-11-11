using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBusiness
{
    public interface IOrder
    {
        DateTime Delivery { get; set; }
        string StoreName { get; set; }
        IVehicle Vehicle { get; set; }
        
       
    }
}
