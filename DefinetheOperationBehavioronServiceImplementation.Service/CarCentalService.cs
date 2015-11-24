using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace DefinetheOperationBehavioronServiceImplementation.Service
{
    [ServiceBehavior(InstanceContextMode=InstanceContextMode.PerCall)]
    public class CarCentalService : ICarCentalService
    {
        [OperationBehavior(
            AutoDisposeParameters=true,
            Impersonation=ImpersonationOption.NotAllowed,
            ReleaseInstanceMode=ReleaseInstanceMode.None,
            TransactionAutoComplete=true,
            TransactionScopeRequired=false)]
        public double CalculatePrice(DateTime pickupDate, DateTime returnDate, string pickupLocation, string vehiclePerference)
        {
            //call to some internal business logic
            Random r = new Random(DateTime.Now.Millisecond);
            return r.NextDouble() * 500;
        }
    }
}
