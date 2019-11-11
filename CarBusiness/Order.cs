using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBusiness
{
   public class Order:IOrder
    {
        public string StoreName { get; set; }
       
        public DateTime Delivery { get; set; }
        public IVehicle Vehicle { get; set; }
       
    }
}
