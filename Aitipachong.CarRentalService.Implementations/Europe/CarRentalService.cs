using Aitipachong.CarRentalService.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aitipachong.CarRentalService.Implementations.Europe
{
    public class CarRentalService : ICarRentalService
    {
        public double CalulatePrice(DateTime pickupDate, DateTime returnDate, string pickupLocation, string vehiclePreference)
        {
            //call to some internal business logic
            Random r = new Random(DateTime.Now.Millisecond);
            return r.NextDouble() * 500;
        }
    }
}
