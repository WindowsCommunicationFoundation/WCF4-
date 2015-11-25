using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace SettheClientCredentialsontheConfigFile.Service
{
    [ServiceContract]
    public interface ICarRentalService
    {
        [OperationContract]
        double CalculatePrice(DateTime pickupDate, DateTime returnDate, string pickupLocation, string vehiclePerference);
    }
}
