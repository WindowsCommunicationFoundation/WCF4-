using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;

namespace Aitipachong.CarRentalService.ConsoleHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using(ServiceHost host = new ServiceHost(typeof(CarRentalService.Implementations.Europe.CarRentalService)))
            {
                host.AddServiceEndpoint(typeof(CarRentalService.Contracts.ICarRentalService), new WSHttpBinding(), "http://127.0.0.1:9999/CarRentalService");
                if(host.Description.Behaviors.Find<ServiceMetadataBehavior>() == null)
                {
                    ServiceMetadataBehavior behavior = new ServiceMetadataBehavior();
                    behavior.HttpGetEnabled = true;
                    behavior.HttpGetUrl = new Uri("http://127.0.0.1:9999/CarRentalService/metadata");
                    host.Description.Behaviors.Add(behavior);
                }

                host.Opened += delegate
                {
                    Console.WriteLine("CarRentalService已经启动，按任意键终止服务!");
                };
                host.Open();
                Console.Read();
            }
        }
    }
}


  // 6: namespace Artech.WcfServices.Hosting
  // 7: {
  // 8:     class Program
  // 9:     {
  //10:         static void Main(string[] args)
  //11:         {
  //12:             using (ServiceHost host = new ServiceHost(typeof(CalculatorService)))
  //13:             {
  //14:                 host.AddServiceEndpoint(typeof(ICalculator), new WSHttpBinding(), "http://127.0.0.1:9999/calculatorservice");
  //15:                 if (host.Description.Behaviors.Find<ServiceMetadataBehavior>() == null)
  //16:                 {
  //17:                     ServiceMetadataBehavior behavior = new ServiceMetadataBehavior();
  //18:                     behavior.HttpGetEnabled = true;
  //19:                     behavior.HttpGetUrl = new Uri("http://127.0.0.1:9999/calculatorservice/metadata");
  //20:                     host.Description.Behaviors.Add(behavior);
  //21:                 }
  //22:                 host.Opened += delegate
  //23:                 {
  //24:                     Console.WriteLine("CalculaorService已经启动，按任意键终止服务！");
  //25:                 };
  //26:  
  //27:                 host.Open();
  //28:                 Console.Read();
  //29:             }
  //30:         }
  //31:     }
  //32: }