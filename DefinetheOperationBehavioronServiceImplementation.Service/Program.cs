using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;

namespace DefinetheOperationBehavioronServiceImplementation.Service
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(CarCentalService), new Uri("http://localhost:8080/CarRentalService"));
            ServiceMetadataBehavior serviceMetadata =
            host.Description.Behaviors.Find<ServiceMetadataBehavior>();
            if (serviceMetadata == null)
            {
                serviceMetadata = new ServiceMetadataBehavior();
                host.Description.Behaviors.Add(serviceMetadata);
            }
            serviceMetadata.HttpGetEnabled = true;
            BasicHttpBinding binding = new BasicHttpBinding();
            host.AddServiceEndpoint(typeof(ICarCentalService), binding, "http://localhost:8080/CarRentalService");

            try
            {
                host.Open();

                Console.WriteLine("The car rental service is up.");                
                Console.ReadLine();

                host.Close();
            }
            catch (CommunicationException ex)
            {
                host.Abort();
                Console.WriteLine(ex);
            }
            catch (TimeoutException ex)
            {
                host.Abort();
                Console.WriteLine(ex);
            }
            catch (Exception ex)
            {
                host.Abort();
                Console.WriteLine(ex);
            }
        }
    }
}
