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
            var SkodaSt = new SkodaStore();
            var order2 = SkodaSt.ClientBuyCar(client, "Octavia");
            FordSt.OrderSituation();
            FordSt.CancelOrder(client, order);
            FordSt.OrderSituation();
            SkodaSt.OrderSituation();
            Console.ReadLine();
        }
    }
}
