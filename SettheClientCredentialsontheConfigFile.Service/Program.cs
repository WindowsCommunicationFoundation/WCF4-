using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;
using System.ServiceModel.Security;

namespace SettheClientCredentialsontheConfigFile.Service
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(CarRentalService), new Uri("http://localhost:8080/CarRentalService"));

            ServiceMetadataBehavior serviceMetadata = host.Description.Behaviors.Find<ServiceMetadataBehavior>();
            if(serviceMetadata == null)
            {
                serviceMetadata = new ServiceMetadataBehavior();
                host.Description.Behaviors.Add(serviceMetadata);
            }
            serviceMetadata.HttpGetEnabled = true;

            BasicHttpBinding binding = new BasicHttpBinding();
            binding.Security.Mode = BasicHttpSecurityMode.Message;
            binding.Security.Message.ClientCredentialType = BasicHttpMessageCredentialType.Certificate;

            host.AddServiceEndpoint(typeof(ICarRentalService), binding, "http://localhost:8080/CarRentalService");

            host.Credentials.ClientCertificate.Authentication.CertificateValidationMode = X509CertificateValidationMode.None;
            host.Credentials.ClientCertificate.SetCertificate(StoreLocation.CurrentUser, StoreName.My, X509FindType.FindBySubjectDistinguishedName, "CN=client_cert");
            host.Credentials.ServiceCertificate.SetCertificate(StoreLocation.CurrentUser, StoreName.My, X509FindType.FindBySubjectDistinguishedName, "CN=service_cert");

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

