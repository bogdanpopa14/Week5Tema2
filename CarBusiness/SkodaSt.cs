using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBusiness
{
    class SkodaSt:IStore
    {
        private bool ordin = true;
        public string Name { get; }
        public SkodaSt()
        {
            this.Name = "Skoda";
        }

        private List<IVehicle> cars = new List<IVehicle>
        {
        new Vehicle("Octavia",new Producer ("Skoda")),
        new Vehicle("Fabia",new Producer ("Skoda")),
        new Vehicle("Superb",new Producer ("Skoda")),
        };
        private IOrder order;
        private IVehicle selectCar;
        public IOrder ClientBuyCar(IPerson client, string carName)
        {


            for (int i = 0; i < cars.Count; i++)
            {
                if (cars[i].Name == carName)
                {
                    selectCar = cars[i];
                }
            }
            order = new Order { StoreName = this.Name, Vehicle = selectCar, Delivery = DateTime.Now.AddDays(21) };
            return order;


        }
        public void CancelOrder(IPerson person, IOrder order)
        {
            ordin = false;
        }

        public void OrderSituation()
        {
            if (ordin)
            {
                Console.WriteLine($"Ati cumparat {selectCar.Producer.Name} {selectCar.Name} si ajunge in {order.Delivery}");
            }
            else
            {
                Console.WriteLine($"Ati anulat ordinul initial: {selectCar.Producer.Name} {selectCar.Name}");
            }
        }
    }
}
