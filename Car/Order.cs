using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    public class Order
    {
        public string StoreName { get; }
        public DateTime Delivery { get; }
        
        public Vehicle Car { get; }
        public Order(string name,Vehicle car,DateTime deliv)
        {
            this.Delivery = deliv;
            this.StoreName = name;
            this.Car = car;
        }
    }
}
