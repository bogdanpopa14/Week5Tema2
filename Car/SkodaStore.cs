using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    class SkodaStore:IStore
    {
        private bool ordin = true;
        public string Name { get; }
        public SkodaStore()
        {
            this.Name = "Skoda";
        }
        protected List<Vehicle> listaCars = new List<Vehicle>
        {
            new Vehicle("Octavia", new Producer("Skoda")),
            new Vehicle("Fabia", new Producer("Skoda")),
            new Vehicle("Superb", new Producer("Skoda")),
        };

        private Vehicle selectcar;
        private Order order;
        public Order ClientBuyCar(Customer client, string carName)
        {

            for (int i = 0; i < listaCars.Count; i++)
            {
                if (listaCars[i].Model == carName)
                {
                    selectcar = listaCars[i];

                }
            }
            order = new Order(this.Name, selectcar, DateTime.Now.AddDays(21));
            return order;
        }

        public void CancelOrder(Customer c, Order o)
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
