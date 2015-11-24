using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aitipachong.CarRentalService.ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            using(CarRentalService.ConsoleClient.CarRentalServiceProxy.CarRentalServiceClient carRentalClient
                = new CarRentalServiceProxy.CarRentalServiceClient())
            {
                double price = carRentalClient.CalulatePrice(DateTime.Now, DateTime.Now.AddDays(5),
                    "Graz", "PickUp");
                Console.WriteLine("Price {0}", price);
            }
        }
    }
}
