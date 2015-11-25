using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REST.Service
{
    public class Car
    {
        public string Name { get; set; }
        public string Make { get; set; }
        public string Type { get; set; }
        public int Seats { get; set; }
    }

    [System.Runtime.Serialization.CollectionDataContract(Name="Cars")]
    public class CarPool : List<Car>
    {
        private CarPool()
        {
            this.Add(new Car() 
            {
                Name = "Dakota",
                Make = "Dodge",
                Type = "Pickup Truck",
                Seats = 8
            });

            this.Add(new Car() 
            {
                Name = "TT",
                Make = "Audi",
                Type = "Sport Car",
                Seats = 2
            });
        }

        private static CarPool AllCars = null;
        public static CarPool GetCarPark()
        {
            if(AllCars == null)
            {
                AllCars = new CarPool();
            }
            return AllCars;
        }
    }
}