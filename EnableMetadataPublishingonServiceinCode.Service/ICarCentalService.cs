using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace EnableMetadataPublishingonServiceinCode.Service
{
    [ServiceContract]
    public interface ICarCentalService
    {
        [OperationContract]
        double CalculatePrice(DateTime pickupDate, DateTime returnDate, string pickupLocation, string vehiclePerference);
    }
}
