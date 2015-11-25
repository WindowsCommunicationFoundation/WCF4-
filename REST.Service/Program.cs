using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace REST.Service
{
    class Program
    {
        static void Main(string[] args)
        {
            WebServiceHost webHost = null;
            try
            {
                webHost = new WebServiceHost(typeof(CarRentalService), new Uri("http://localhost:1234"));
                webHost.Open();
                Console.WriteLine("Web service host is open...");
                Console.ReadLine();
            }
            catch(Exception ex)
            {
                if (webHost != null) webHost.Abort();
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
