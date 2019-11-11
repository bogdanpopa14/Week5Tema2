using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    class Program
    {
        static void Main(string[] args)
        {
            var FordSt = new FordStore();
            var client = new Customer("Bogdan");
            var order=FordSt.ClientBuyCar(client, "Fiesta");
            FordSt.OrderSituation();
            FordSt.CancelOrder(client, order);
            FordSt.OrderSituation();
            Console.ReadLine();
        }
    }
}
