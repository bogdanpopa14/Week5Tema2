using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    
    public class Vehicle
    {
        public string Model { get; }
        public Producer Producator { get; }
        public Vehicle(string model,Producer prod)
        {
            this.Model = model;
            this.Producator = prod;
        }

    }
}
