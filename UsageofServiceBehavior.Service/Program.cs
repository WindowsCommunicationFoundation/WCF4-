using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace UsageofServiceBehavior.Service
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(CarCentalService));
            try
            {
                host.Open();
                Console.WriteLine("The car rental service is up.");
                Console.ReadLine();
                host.Close();
            }
            catch(CommunicationException ex)
            {
                host.Abort();
                Console.WriteLine(ex);
            }
            catch(TimeoutException ex)
            {
                host.Abort();
                Console.WriteLine(ex);
            }
            catch(Exception ex)
            {
                host.Abort();
                Console.WriteLine(ex);
            }
        }
    }
}