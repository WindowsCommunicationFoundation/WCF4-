using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Aitipachong.CarRentalService.Contracts
{
    public class PriceCalculationRequest
    {
        public DateTime PickupDate { get; set; }
        public DateTime ReturnDate { get; set; }

        public string PickupLocation { get; set; }

        public string ReturnLocation { get; set; }

        private string VehicleType { get; set; }
        [IgnoreDataMember]
        public string Color { get; set; }
    }

    public class PriceCalculationResponse
    {
        public double Result { get; set; }
    }
}
