using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBusiness
{
    public class Producer:IProducer
    {
        public string Name { get; }
        public Producer(string name)
        {
            this.Name = name;
        }
    }
}
