using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBusiness
{
    class Program
    {
        static void Main(string[] args)
        {
            var Fordstore = new FordSt();
            var SkodaStore = new SkodaSt();
            var client = new Customer("Bogdan");
            
            var otherorder = SkodaStore.ClientBuyCar(client, "Octavia");
            var neworder=Fordstore.ClientBuyCar(client, "Fiesta");
            Fordstore.CancelOrder(client, neworder);
            Fordstore.OrderSituation();
            SkodaStore.OrderSituation();
            Console.ReadLine();
        }
    }
}
