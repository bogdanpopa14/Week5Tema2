using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBusiness
{
    class Vehicle:IVehicle
    {
        public IProducer Producer { get; }
        public string Name { get; }
        public Vehicle(string name,IProducer producer)
        {
            this.Name = name;
            this.Producer = producer;
        }
    }
}
