using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBusiness
{
    public interface IVehicle
    {
        IProducer Producer { get; }
        string Name { get; }
    }
}
