using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    public class FordStore:IStore
    {
        private bool ordin = true;
        public string Name { get; }
        public FordStore()
        {
            this.Name = "Ford";
        }
        protected List<Vehicle> listaCars = new List<Vehicle> 
        { 
            new Vehicle("Fiesta", new Producer("Ford")),
            new Vehicle("Focus", new Producer("Ford")),
            new Vehicle("Mondeo", new Producer("Ford")),
        };

        private Vehicle selectcar;
        private Order order;
        public Order ClientBuyCar(Customer client, string carName)
        {
            
            for (int i = 0; i < listaCars.Count; i++)
            {
                if(listaCars[i].Model==carName)
                {
                    selectcar = listaCars[i];

                }
            }
             order = new Order(this.Name, selectcar, DateTime.Now.AddDays(28));
            return order;
        }

        public void CancelOrder(Customer c,Order o)
        {
            ordin = false;
        }

        public void OrderSituation()
        {
            if (ordin)
            {
                Console.WriteLine($"Ati cumparat {selectcar.Producator.Name} {selectcar.Model} si ajunge in {order.Delivery}");
            }
            else
            {
                Console.WriteLine($"Ati anulat ordinul initial: {selectcar.Producator.Name} {selectcar.Model}");
            }
        }
    }
}
