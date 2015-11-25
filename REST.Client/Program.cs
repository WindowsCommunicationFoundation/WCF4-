using Microsoft.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REST.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            using(HttpClient restClient = new HttpClient())
            {
                HttpResponseMessage resp = restClient.Get("http://localhost:1234/CarPool");
                resp.EnsureStatusIsSuccessful();
                Console.WriteLine(resp.Headers.ToString());

                var result = resp.Content.ReadAsString();
                Console.WriteLine(result);

                string newCar = "<Car xmlns=\"http://schemas.datacontract.org/2004/07/Wrox\"><Make> Seat </Make> <Name> Leon </Name><Seats> 5 </Seats> <Type> Sport Car </Type> </Car> ";
                restClient.Put("http://localhost:1234/CarPool/Leon", "application/xml", HttpContent.Create(newCar));
                Console.WriteLine(resp.StatusCode);

                resp = restClient.Get("http://localhost:1234/CarPool");
                resp.EnsureStatusIsSuccessful();
                var result1 = resp.Content.ReadAsString();
                Console.WriteLine(result1);
            }
        }
    }
}
/*
             using (HttpClient restClient = new HttpClient())
            {
                HttpResponseMessage resp = restClient.Get("http://localhost:1234/CarPool");
                resp.EnsureStatusIsSuccessful();
                Console.WriteLine(resp.Headers.ToString());
                var result = resp.Content.ReadAsString();
                Console.WriteLine(result);
                string newCar = "<Car xmlns=\"http://schemas.datacontract.org/2004/07/Wrox\"><Make> Seat </Make> <Name> Leon </Name><Seats> 5 </Seats> <Type> Sport Car </Type> </Car> ";
                restClient.Put("http://localhost:1234/CarPool/Leon", "application/xml", HttpContent.Create(newCar));
                Console.WriteLine(resp.StatusCode);
            }
 */