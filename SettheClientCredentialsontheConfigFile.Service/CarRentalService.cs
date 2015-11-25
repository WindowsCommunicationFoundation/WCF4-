using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace SettheClientCredentialsontheConfigFile.Service
{
    [ServiceBehavior(InstanceContextMode=InstanceContextMode.PerCall)]
    public class CarRentalService : ICarRentalService
    {
        [OperationBehavior(
            AutoDisposeParameters = true,
            Impersonation = ImpersonationOption.NotAllowed,
            ReleaseInstanceMode = ReleaseInstanceMode.None,
            TransactionAutoComplete = true,
            TransactionScopeRequired = false)]
        public double CalculatePrice(DateTime pickupDate, DateTime returnDate, string pickupLocation, string vehiclePerference)
        {
            // insert service logic (call to NextDouble() is only for the purpose of this sample)
            return new Random().NextDouble() * 1000;
        }
    }
}