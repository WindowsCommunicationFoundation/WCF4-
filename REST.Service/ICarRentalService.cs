using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace REST.Service
{
    [ServiceContract]
    public interface ICarRentalService
    {
        [OperationContract]
        string HelloWorld();

        [OperationContract]
        [WebGet(UriTemplate = "/CarPool")]
        CarPool GetAllCars();

        [OperationContract]
        [WebGet(UriTemplate = "/CarPool/{carName}")]
        Car GetCar(string carName);

        [OperationContract]
        [WebGet(UriTemplate = "/CarPool/{carName}?format=xml",
            ResponseFormat = WebMessageFormat.Xml)]
        Car GetCarXML(string carName);

        [OperationContract]
        [WebGet(UriTemplate = "/CarPool/{carName}?format=json",
            ResponseFormat = WebMessageFormat.Json)]
        Car GetCarJSON(string carName);

        [OperationContract]
        [WebInvoke(UriTemplate = "CarPool/{carName}", Method = "PUT")]
        Car AddCar(string carName, Car car);

        [OperationContract]
        [WebInvoke(UriTemplate = "/CarPool/{carName}", Method = "DELETE")]
        void DeleteCar(string carName);
    }
}