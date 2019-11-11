using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBusiness
{
    public class Customer:IPerson
    {
        public string Name { get; }
        public Customer(string name)
        {
            this.Name = name;
        }
    }
}
