using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace REST.Service
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class CarRentalService : ICarRentalService
    {
        public string HelloWorld()
        {
            WebOperationContext.Current.OutgoingResponse.StatusCode = System.Net.HttpStatusCode.OK;
            return "Hello World";
        }

        public CarPool GetAllCars()
        {
            return CarPool.GetCarPark();
        }

        public Car GetCar(string carName)
        {
            return CarPool.GetCarPark().Find(e => e.Name == carName);
        }

        public Car GetCarXML(string carName)
        {
            return GetCar(carName);
        }

        public Car GetCarJSON(string carName)
        {
            return GetCar(carName);
        }

        public Car AddCar(string carName, Car car)
        {
            WebOperationContext.Current.OutgoingResponse.SetStatusAsCreated
                (
                new Uri("http://localhost:1234/CarPool/" + car.Name)
                );
            CarPool.GetCarPark().Add(car);
            return car;
        }

        public void DeleteCar(string carName)
        {
            Car found = CarPool.GetCarPark().Find(e => e.Name == carName);
            if (found == null)
            {
                WebOperationContext.Current.OutgoingResponse.SetStatusAsNotFound();
            }
            else
            {
                CarPool.GetCarPark().Remove(found);
            }
        }
    }
}