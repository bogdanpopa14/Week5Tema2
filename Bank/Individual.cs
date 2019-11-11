using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Individual:ICustomer
    {
        public int Age { get; }
        public string Name { get; }
        public Individual(string nume,int age)
        {
            this.Name = nume;
            if (age >= 18)
            {
                this.Age = age;
            }
            else { Console.WriteLine("Varsta prea mica"); }
        }
        
        
    }
}
